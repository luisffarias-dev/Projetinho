package com.projetinho.projetinho.service;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.cache.annotation.CacheEvict;
import org.springframework.cache.annotation.CachePut;
import org.springframework.cache.annotation.Cacheable;
import org.springframework.stereotype.Service;

import com.projetinho.projetinho.model.Cardio;
import com.projetinho.projetinho.model.Treino;
import com.projetinho.projetinho.repository.CardioRepository;

@Service
public class CardioService {

    @Autowired
    private CardioRepository cardioRepo;

    @Cacheable(value = "cardio", key = "#email")
    public List<Cardio> buscarCardiosPorEmail(String email) {
        return cardioRepo.findByEmail(email);
    }


    // Salvar novo treino e atualizar cache
    @CachePut(value = "cardio", key = "#cardio.email")
    public Cardio salvarNoCache(Cardio cardio) {
        return cardioRepo.save(cardio);
    }

    // Limpar cache para o email
    @CacheEvict(value = "cardio", key = "#email")
    public void limparCachePorEmail(String email) {
        // Apenas limpa o cache do usuário
    }
    
    
    @Cacheable(value = "cardio", key = "#email")
    public List<Cardio> listarCardioPorEmail(String email) {
        return cardioRepo.findByEmail(email);
    }
    
    @CacheEvict(value = "cardio", key = "#email")
    public void limparCacheCardio(String email) {
        
    }
}
