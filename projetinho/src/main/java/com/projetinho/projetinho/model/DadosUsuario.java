package com.projetinho.projetinho.model;

import jakarta.persistence.*;

@Entity
@Table(name = "DadosUsuario")
public class DadosUsuario {

    @Id
    private String email;

    private String nome;
    private String sexo;
    private String dataNasc;
    private Double altura;
    private Double peso;
    private String imagem;

    @OneToOne
    @JoinColumn(name = "email", referencedColumnName = "login", insertable = false, updatable = false)
    private Login login;

    public DadosUsuario() {
    }

    public DadosUsuario(String email, String nome, String sexo, String dataNasc, Double altura, Double peso, String imagem) {
        this.email = email;
        this.nome = nome;
        this.sexo = sexo;
        this.dataNasc = dataNasc;
        this.altura = altura;
        this.peso = peso;
        this.imagem = imagem;
    }

    // Getters e Setters

    public String getEmail() {
        return email;
    }

    public void setEmail(String email) {
        this.email = email;
    }

    public String getNome() {
        return nome;
    }

    public void setNome(String nome) {
        this.nome = nome;
    }

    public String getSexo() {
        return sexo;
    }

    public void setSexo(String sexo) {
        this.sexo = sexo;
    }

    public String getDataNasc() {
        return dataNasc;
    }

    public void setDataNasc(String dataNasc) {
        this.dataNasc = dataNasc;
    }

    public Double getAltura() {
        return altura;
    }

    public void setAltura(Double altura) {
        this.altura = altura;
    }

    public Double getPeso() {
        return peso;
    }

    public void setPeso(Double peso) {
        this.peso = peso;
    }

    public String getImagem() {
        return imagem;
    }

    public void setImagem(String imagem) {
        this.imagem = imagem;
    }

    public Login getLogin() {
        return login;
    }

    public void setLogin(Login login) {
        this.login = login;
    }
}
