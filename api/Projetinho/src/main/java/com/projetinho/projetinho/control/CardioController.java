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

import com.projetinho.projetinho.model.Cardio;
import com.projetinho.projetinho.repository.CardioRepository;
import com.projetinho.projetinho.service.CardioService;

import io.swagger.v3.oas.annotations.Operation;

@RestController
@RequestMapping("/cardio")
public class CardioController {

    @Autowired
    private CardioService cachingCardio;

    @Autowired
    private CardioRepository repC;

   
    
    @Operation(description = "Lista os cardios", summary = "Listar os cardios", tags = "Cardio")
    @GetMapping
    public List<Cardio> listarTodos() {
        return repC.findAll();
    }
    
    @Operation(description = "Lista cardio por email", summary = "Cardio por email", tags = "Cardio")
    @GetMapping("/cardio/{email}")
    public List<Cardio> listarPorEmail(@PathVariable String email) {
        return repC.findByEmail(email);
    }
    
    @Operation(description = "Salva os treino de cardio", summary = "Salvar cardio", tags = "Cardio")
    @PostMapping("/salvar")
    public Cardio salvarCardio(@RequestBody Cardio cardio) {
        return repC.save(cardio);
    }

    @Operation(description = "Apaga um cardio", summary = "Apagar treino cardio", tags = "Cardio")
	@DeleteMapping("/excluir")
	public ResponseEntity<String> excluirCardio(@RequestParam Long Id) {
	    try {
	        repC.deleteById(Id);  // método nativo do JpaRepository
	        return ResponseEntity.ok("Treino excluído com sucesso!");
	    } catch (Exception e) {
	        return ResponseEntity.status(500).body("Erro ao excluir treino: " + e.getMessage());
	    }
	}
    
    @Operation(description = "Este endpoint salva os cardios do usuario no cache", summary = "salvar cardios no cache", tags = "Cardio")
    @GetMapping("/cache/{email}")
    public ResponseEntity<List<Cardio>> buscarCardiosCache(@PathVariable String email) {
        List<Cardio> cardios = cachingCardio.buscarCardiosPorEmail(email);
        if (cardios != null && !cardios.isEmpty()) {
            return ResponseEntity.ok(cardios);
        } else {
            return ResponseEntity.noContent().build(); // Ou notFound() se quiser
        }
}
    @Operation(description = "Busca todos os treinos de cardio do usuário pelo email e salva no cache para uso posterior", summary = "Buscar e cachear cardio por email", tags = "Cardio")
	@GetMapping("/cardioCache")
	public ResponseEntity<List<Cardio>> buscarETreinarPorEmail(@RequestParam String email) {
		List<Cardio> cardios = cachingCardio.listarCardioPorEmail(email);
		return ResponseEntity.ok(cardios);
	}
    
    @Operation(description = "Este apaga o cache de treinos ", summary = "Apagar Cache", tags = "Treino")
	 @DeleteMapping("/limparCache/{email}")
	    public ResponseEntity<String> limparCache(@PathVariable String email) {
    	cachingCardio.limparCacheCardio(email);
	        return ResponseEntity.ok("Cache limpo para email: " + email);
	    }
}
