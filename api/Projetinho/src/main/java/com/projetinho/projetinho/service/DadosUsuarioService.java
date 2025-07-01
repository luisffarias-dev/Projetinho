package com.projetinho.projetinho.service;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.cache.annotation.CacheEvict;
import org.springframework.cache.annotation.CachePut;
import org.springframework.cache.annotation.Cacheable;
import org.springframework.stereotype.Service;

import com.projetinho.projetinho.model.DadosUsuario;
import com.projetinho.projetinho.repository.DadosUsuarioRepository;

@Service
public class DadosUsuarioService {

    @Autowired
    private DadosUsuarioRepository dadosRepo;

    @Cacheable(value = "dadosUsuario", key = "#email")
    public DadosUsuario buscarDadosPorEmail(String email) {
        return dadosRepo.findById(email).orElse(null);
    }

    @CachePut(value = "dadosUsuario", key = "#dados.email")
    public DadosUsuario salvarNoCache(DadosUsuario dados) {
        return dados;
    }

    @CacheEvict(value = "dadosUsuario", key = "#email")
    public void limparCachePorEmail(String email) {
        // Intencionalmente vazio — apenas limpa o cache
    }
}
