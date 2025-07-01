package com.projetinho.projetinho.repository;

import java.util.List;

import org.springframework.data.jpa.repository.JpaRepository;

import com.projetinho.projetinho.model.Treino;

public interface TreinoRepository extends JpaRepository<Treino, Long> {
    List<Treino> findByEmail(String email);
    List<Treino> findByEmailAndData(String email, String data);
    
    void deleteByEmail(String email);


}
