package com.projetinho.projetinho.swaggerconfig;

import org.springframework.context.annotation.Bean;
import org.springframework.context.annotation.Configuration;

import io.swagger.v3.oas.models.OpenAPI;
import io.swagger.v3.oas.models.info.License;

@Configuration
public class SwaggerConfig {
	
	@Bean
	public OpenAPI configurarSwagger() {
		
		return new OpenAPI().info(new io.swagger.v3.oas.models.info.Info().title("Projetinho")
				.description("Projeto para criação de treinos para usuários de academia")
				.summary("Este é um projeto para criar de acordo com os dados de cada usuário um treino específico")
				.version("1.0.0")
				.termsOfService("Você concorda em utilizar nossa aplicação?")
				.license(new License().url("pagina_licenca").name("Premium User"))
				);			
	}

}
