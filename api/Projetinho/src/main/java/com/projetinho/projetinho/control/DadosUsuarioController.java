package com.projetinho.projetinho.control;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

import com.projetinho.projetinho.model.DadosUsuario;
import com.projetinho.projetinho.repository.DadosUsuarioRepository;
import com.projetinho.projetinho.service.DadosUsuarioService;

import io.swagger.v3.oas.annotations.Operation;


@RestController
@RequestMapping("/usuario")
public class DadosUsuarioController {

    @Autowired
    private DadosUsuarioService cachingService;

    @Autowired
    private DadosUsuarioRepository repD;

 
    @Operation(description = "Este endpoint salva os dados do usuario no cache", summary = "salvar dados no cache", tags = "DadosUsuario")
    @GetMapping("/dados/cache/{email}")
    public ResponseEntity<DadosUsuario> buscarDadosCache(@PathVariable String email) {
        DadosUsuario dados = cachingService.buscarDadosPorEmail(email);
        if (dados != null) {
            return ResponseEntity.ok(dados);
        } else {
            return ResponseEntity.notFound().build();
        }
    }

    // Limpar cache
    @Operation(description = "Este endpoint limpa os dados do usuario no cache", summary = "limpar dados no cache", tags = "DadosUsuario")
    @GetMapping("/dados/cache/apagar/{email}")
    public ResponseEntity<Void> limparDadosCache(@PathVariable String email) {
        cachingService.limparCachePorEmail(email);
        return ResponseEntity.noContent().build();
    }

    // Salvar ou atualizar dados (insere e também salva no cache)
    @Operation(description = "Este endpoint salva ou atualiza os dados do usuario banco", summary = "salvar dados no banco", tags = "DadosUsuario")
    @PostMapping("/salvar")
    public ResponseEntity<String> salvarOuAtualizar(@RequestBody DadosUsuario dados) {
        try {
            repD.save(dados); // Salva no banco
            cachingService.salvarNoCache(dados); // Atualiza o cache
            return ResponseEntity.ok("Dados salvos com sucesso");
        } catch (Exception e) {
            return ResponseEntity.status(HttpStatus.BAD_REQUEST).body("Erro: " + e.getMessage());
        }
    }
    
    @Operation(description = "Chama todos os dados", summary = "Todos os dados", tags = "DadosUsuario")
    @GetMapping("/todos")
    public List<DadosUsuario> listarTodosUsuarios() {
        return repD.findAll();
    }
    
}
