package com.projetinho.projetinho.model;

import jakarta.persistence.*;

@Entity
@Table(name = "Treino")
public class Treino {

    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Long id;

    private String email;
    private String musculo;
    private String exercicio;
    private Double carga;
    private int repeticoes;
    private Double descanso;
    private String data;

    @ManyToOne
    @JoinColumn(name = "email", referencedColumnName = "login", insertable = false, updatable = false)
    private Login login;

    public Treino() {
    }

    public Treino(String email, String musculo, String exercicio, Double carga, int repeticoes, Double descanso, String data) {
        this.email = email;
        this.musculo = musculo;
        this.exercicio = exercicio;
        this.carga = carga;
        this.repeticoes = repeticoes;
        this.descanso = descanso;
        this.data = data;
    }

    // Getters e setters

    public Long getId() {
        return id;
    }

    public String getEmail() {
        return email;
    }

    public void setEmail(String email) {
        this.email = email;
    }

    public String getMusculo() {
        return musculo;
    }

    public void setMusculo(String musculo) {
        this.musculo = musculo;
    }

    public String getExercicio() {
        return exercicio;
    }

    public void setExercicio(String exercicio) {
        this.exercicio = exercicio;
    }

    public Double getCarga() {
        return carga;
    }

    public void setCarga(Double carga) {
        this.carga = carga;
    }

    public int getRepeticoes() {
        return repeticoes;
    }

    public void setRepeticoes(int repeticoes) {
        this.repeticoes = repeticoes;
    }

    public Double getDescanso() {
        return descanso;
    }

    public void setDescanso(Double descanso) {
        this.descanso = descanso;
    }

    public String getData() {
        return data;
    }

    public void setData(String data) {
        this.data = data;
    }

    public Login getLogin() {
        return login;
    }

    public void setLogin(Login login) {
        this.login = login;
    }
}
