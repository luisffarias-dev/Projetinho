package com.projetinho.projetinho.service;

import java.util.Optional;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.cache.annotation.Cacheable;
import org.springframework.http.HttpStatus;
import org.springframework.stereotype.Service;
import org.springframework.web.server.ResponseStatusException;

import com.projetinho.projetinho.model.Login;
import com.projetinho.projetinho.repository.LoginRepository;

@Service
public class LoginService {

    @Autowired
    private LoginRepository repL;


    
    public Login buscarPorLogin(String login) {
        return repL.findById(login)
                .orElseThrow(() -> new ResponseStatusException(HttpStatus.NOT_FOUND, "Usuário não encontrado"));
    }

}
