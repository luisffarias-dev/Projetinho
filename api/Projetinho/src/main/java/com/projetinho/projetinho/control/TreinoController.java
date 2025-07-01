package com.projetinho.projetinho.control;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.DeleteMapping;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.bind.annotation.RestController;

import com.projetinho.projetinho.model.Treino;
import com.projetinho.projetinho.repository.TreinoRepository;
import com.projetinho.projetinho.service.TreinoService;

import io.swagger.v3.oas.annotations.Operation;

@RestController
@RequestMapping("/treino")
public class TreinoController {

	@Autowired
	private TreinoRepository repT;

	@Autowired
	private TreinoService treinoService;

	@Operation(description = "Lista os treinos com base no e-mail e data", summary = "Listar treinos por e-mail e data", tags = "Treino")
	@GetMapping("/treinos")
	public ResponseEntity<List<Treino>> listarTreinosPorEmailEData(@RequestParam String email,
			@RequestParam String data) {
		List<Treino> treinos = treinoService.listarTreinosPorEmailEData(email, data);
		return ResponseEntity.ok(treinos);
	}

	@Operation(description = "Lista todos os treinos apenas por e-mail", summary = "Listar treinos por e-mail", tags = "Treino")
	@GetMapping("/porEmail")
	public ResponseEntity<List<Treino>> listarApenasPorEmail(@RequestParam String email) {
		List<Treino> treinos = repT.findByEmail(email);

		if (treinos.isEmpty()) {
			return ResponseEntity.notFound().build();
		}
		return ResponseEntity.ok(treinos);
	}

	@Operation(description = "Este endpoint salva todos treinos baseados no tipo", summary = "Salvar treinos gerados", tags = "Treino")
	@PostMapping("/salvarTipo")
	public ResponseEntity<String> salvarTreinosPorTipo(@RequestBody List<Treino> treinos) {
		try {
			repT.saveAll(treinos);
			return ResponseEntity.ok("Treinos salvos com sucesso!");
		} catch (Exception e) {
			return ResponseEntity.status(500).body("Erro ao salvar treinos: " + e.getMessage());
		}
	}

	@Operation(description = "Busca todos os treinos do usuário pelo email e salva no cache para uso posterior", summary = "Buscar e cachear treinos por email", tags = "Treino")
	@GetMapping("/treinosCache")
	public ResponseEntity<List<Treino>> buscarETreinarPorEmail(@RequestParam String email) {
		List<Treino> treinos = treinoService.listarTreinosPorEmail(email);
		return ResponseEntity.ok(treinos);
	}
	
	@Operation(description = "Este endpoint salva treinos ", summary = "Salvar treinos", tags = "Treino")
	@PostMapping("/salvarTreino")
	public ResponseEntity<String> salvarTreinos(@RequestBody List<Treino> treinos) {
		try {
			repT.saveAll(treinos);
			return ResponseEntity.ok("Treinos salvos com sucesso!");
		} catch (Exception e) {
			return ResponseEntity.status(500).body("Erro ao salvar treinos: " + e.getMessage());
		}
			
	}
	
	@Operation(description = "Apaga um treino", summary = "Apagar treino", tags = "Treino")
	@DeleteMapping("/excluir")
	public ResponseEntity<String> excluirTreino(@RequestParam Long Id) {
	    try {
	        repT.deleteById(Id);  // método nativo do JpaRepository
	        return ResponseEntity.ok("Treino excluído com sucesso!");
	    } catch (Exception e) {
	        return ResponseEntity.status(500).body("Erro ao excluir treino: " + e.getMessage());
	    }
	}

	
	@Operation(description = "Este apaga o cache de treinos ", summary = "Apagar Cache", tags = "Treino")
	 @DeleteMapping("/limparCache/{email}")
	    public ResponseEntity<String> limparCache(@PathVariable String email) {
	        treinoService.limparCacheTreino(email);
	        return ResponseEntity.ok("Cache limpo para email: " + email);
	    }
	
}
