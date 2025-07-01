package com.projetinho.projetinho.repository;

import org.springframework.data.jpa.repository.JpaRepository;
import com.projetinho.projetinho.model.Login;

public interface LoginRepository extends JpaRepository<Login, String> {
    
}
