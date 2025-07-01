package com.projetinho.projetinho.repository;

import java.util.List;

import org.springframework.data.jpa.repository.JpaRepository;

import com.projetinho.projetinho.model.DadosUsuario;

public interface DadosUsuarioRepository extends JpaRepository<DadosUsuario, String> {
	List<DadosUsuario> findByLogin_AdmFalse();
	void deleteByLogin_Login(String login);
}
