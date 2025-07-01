package com.projetinho.projetinho.control;

import java.util.Map;
import java.util.Optional;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.transaction.annotation.Transactional;
import org.springframework.web.bind.annotation.DeleteMapping;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.PutMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;
import org.springframework.web.server.ResponseStatusException;

import com.projetinho.projetinho.model.Login;
import com.projetinho.projetinho.repository.CardioRepository;
import com.projetinho.projetinho.repository.DadosUsuarioRepository;
import com.projetinho.projetinho.repository.LoginRepository;
import com.projetinho.projetinho.repository.TreinoRepository;
import com.projetinho.projetinho.service.LoginService;

import io.swagger.v3.oas.annotations.Operation;

@RestController
@RequestMapping("/login")
public class LoginController {

	@Autowired
	private LoginRepository repL;
	
	@Autowired
	private DadosUsuarioRepository repD;
	
	@Autowired
	private TreinoRepository repT;
	
	@Autowired
	private CardioRepository repC;

	@Autowired
	private LoginService cachingService;

	@Operation(description = "Este endpoint cadastra um novo usuário no sistema", summary = "Cria os logins", tags = "Login")
	@PostMapping("/cadastro")
	public Login cadastrar(@RequestBody Login loginRecebido) {
		Login novoLogin = new Login();
		novoLogin.setLogin(loginRecebido.getLogin());
		novoLogin.setSenha(loginRecebido.getSenha());
		novoLogin.setStatus(false); // padrão false
		novoLogin.setAdm(false); // padrão false

		return repL.save(novoLogin);
	}

	@Operation(description = "Este endpoint verifica se o login e senha correspondem", summary = "verifica o login", tags = "Login")
	@PostMapping("/login")
	public Login login(@RequestBody Login loginRecebido) {
		Optional<Login> loginExistente = repL.findById(loginRecebido.getLogin());

		if (loginExistente.isPresent()) {
			Login usuario = loginExistente.get();

			if (!usuario.getSenha().equals(loginRecebido.getSenha())) {
				throw new ResponseStatusException(HttpStatus.UNAUTHORIZED, "Senha incorreta");
			}

			if (usuario.isStatus()) {
				throw new ResponseStatusException(HttpStatus.FORBIDDEN, "Usuário bloqueado");
			}

			return usuario;
		} else {
			throw new ResponseStatusException(HttpStatus.NOT_FOUND, "Usuário não encontrado");
		}
	}

	@Operation(description = "Esse endpoint atualiza senha", summary = "atualiza a senha", tags = "Login")
	@PostMapping("/alterarSenha")
	public ResponseEntity<String> alterarSenha(@RequestBody Map<String, String> dados) {
		String email = dados.get("email");
		String senhaAntiga = dados.get("senhaAtual");
		String novaSenha = dados.get("novaSenha");

		Optional<Login> optionalLogin = repL.findById(email);
		if (optionalLogin.isPresent()) {
			Login login = optionalLogin.get();

			if (!login.getSenha().equals(senhaAntiga)) {
				return ResponseEntity.status(HttpStatus.UNAUTHORIZED).body("Senha atual incorreta.");
			}

			login.setSenha(novaSenha);
			repL.save(login);
			return ResponseEntity.ok("Senha atualizada com sucesso.");
		} else {
			return ResponseEntity.status(HttpStatus.NOT_FOUND).body("Usuário não encontrado.");
		}
	}

	@Operation(description = "Esse salva os dados em cache", summary = "dados em cache", tags = "Login")
	@GetMapping("/{login}")
	public Login buscarPorLogin(@PathVariable String login) {
		return cachingService.buscarPorLogin(login);
	}
	
	@Operation(description = "Atualiza o Status", summary = "Alterar Status", tags = "Login")
	@PutMapping("/login/status/{email}")
	public ResponseEntity<String> alterarStatus(@PathVariable String email, @RequestBody Map<String, Boolean> statusData) {
	    boolean novoStatus = statusData.get("status");
	    Optional<Login> loginOptional = repL.findById(email);
	    
	    if (loginOptional.isPresent()) {
	        Login login = loginOptional.get();
	        login.setStatus(novoStatus);
	        repL.save(login);
	        return ResponseEntity.ok("Status atualizado com sucesso.");
	    } else {
	        return ResponseEntity.status(HttpStatus.NOT_FOUND).body("Usuário não encontrado.");
	    }
	}
	
	@Operation(description = "Excluir tudo", summary = "Exclui todos dados", tags = "Login")
	@DeleteMapping("/login/excluirTudo/{email}")
	@Transactional
	public ResponseEntity<String> deletarUsuario(@PathVariable String email) {
	    try {
	        if (!repL.existsById(email)) {
	            return ResponseEntity.status(HttpStatus.NOT_FOUND).body("Usuário não encontrado.");
	        }

	        repC.deleteByEmail(email);
	        repT.deleteByEmail(email);
	        repD.deleteByLogin_Login(email);
	        repL.deleteById(email);

	        return ResponseEntity.ok("Usuário deletado com sucesso.");
	    } catch (Exception e) {
	        // Retorna a mensagem da exceção para ajudar a debugar
	        return ResponseEntity.status(HttpStatus.INTERNAL_SERVER_ERROR).body("Erro ao deletar usuário: " + e.getMessage());
	    }
	}


}
