package com.projetinho.projetinho.model;

import jakarta.persistence.*;

@Entity
@Table(name = "Cardio")
public class Cardio {

    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Long id;

    @Column(name = "login_email", nullable = false)
    private String email;

    private String tipoCardio;
    private int tempoMinutos;
    private String intensidade;
    private double caloriasGastas;

    @Column(name = "data", nullable = false)
    private String data;

    @ManyToOne
    @JoinColumn(name = "login_email", referencedColumnName = "login", insertable = false, updatable = false)
    private Login login;

    public Cardio() {}

    public Cardio(String email, String tipoCardio, int tempoMinutos, String intensidade, double caloriasGastas, String data) {
        this.email = email;
        this.tipoCardio = tipoCardio;
        this.tempoMinutos = tempoMinutos;
        this.intensidade = intensidade;
        this.caloriasGastas = caloriasGastas;
        this.data = data;
    }

    // Getters e Setters

    public Long getId() {
        return id;
    }

    public void setId(Long id) {
        this.id = id;
    }

    public String getEmail() {
        return email;
    }

    public void setEmail(String email) {
        this.email = email;
    }

    public String getTipoCardio() {
        return tipoCardio;
    }

    public void setTipoCardio(String tipoCardio) {
        this.tipoCardio = tipoCardio;
    }

    public int getTempoMinutos() {
        return tempoMinutos;
    }

    public void setTempoMinutos(int tempoMinutos) {
        this.tempoMinutos = tempoMinutos;
    }

    public String getIntensidade() {
        return intensidade;
    }

    public void setIntensidade(String intensidade) {
        this.intensidade = intensidade;
    }

    public double getCaloriasGastas() {
        return caloriasGastas;
    }

    public void setCaloriasGastas(double caloriasGastas) {
        this.caloriasGastas = caloriasGastas;
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
