package com.projetinho.projetinho.service;

import java.util.List;
import java.util.stream.Collectors;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.cache.CacheManager;
import org.springframework.cache.annotation.CacheEvict;
import org.springframework.cache.annotation.Cacheable;
import org.springframework.stereotype.Service;

import com.projetinho.projetinho.model.Treino;
import com.projetinho.projetinho.repository.TreinoRepository;

@Service
public class TreinoService {

    @Autowired
    private TreinoRepository treinoRepository;

    @Autowired
    private CacheManager cacheManager;

    public List<Treino> listarTreinosPorEmailEData(String login, String data) {
        org.springframework.cache.Cache cache = cacheManager.getCache("treinosPorUsuario");
        List<Treino> treinos = cache != null ? cache.get(login, List.class) : null;

        if (treinos == null) {
            // Ajuste aqui: certifique-se de que o método existe em TreinoRepository
            treinos = treinoRepository.findByEmail(login);
            if (cache != null) {
                cache.put(login, treinos);
            }
        }

        return treinos.stream()
                      .filter(t -> t.getData().equals(data))
                      .collect(Collectors.toList());
    }
    
    @Cacheable(value = "Treino", key = "#email")
    public List<Treino> listarTreinosPorEmail(String email) {
        return treinoRepository.findByEmail(email);
    }
    
    @CacheEvict(value = "Treino", key = "#email")
    public void limparCacheTreino(String email) {
        
    }
    
    @Cacheable(value = "treinosPorUsuario", key = "#email + '_' + (#data != null ? #data : '')")
    public List<Treino> buscarTreinosComCache(String email, String data) {
        List<Treino> treinos;

        if (data != null && !data.isEmpty()) {
            treinos = treinoRepository.findByEmailAndData(email, data);
        } else {
            treinos = treinoRepository.findByEmail(email);
        }

        return treinos;
    }
}
