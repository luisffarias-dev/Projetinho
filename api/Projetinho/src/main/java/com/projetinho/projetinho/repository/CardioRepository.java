package com.projetinho.projetinho.repository;

import java.util.List;

import org.springframework.data.jpa.repository.JpaRepository;

import com.projetinho.projetinho.model.Cardio;
import com.projetinho.projetinho.model.Treino;

public interface CardioRepository extends JpaRepository<Cardio, Long> {
	List<Cardio> findByEmail(String email);

	List<Cardio> findByEmailAndData(String email, String data);

	void deleteByEmail(String email);

}
