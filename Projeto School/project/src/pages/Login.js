import '../assets/CSS/Login.css';
import estoque1 from '../assets/Imagens/estoque1.png';
import { useHistory } from "react-router-dom";
import React, { useState } from 'react';
import axios from 'axios';
import {usuarioAutenticado} from '../services/auth'

export default function Login() {

    const [ email, setEmail ] = useState( '' );
    const [ senha, setSenha ] = useState( '' );
    const [ erroMensagem, setErroMensagem ] = useState( '' );
    const [ isLoading, setIsLoading ] = useState( false );

    let history = useHistory();

    // Função que faz a chamada para a API para realizar o login
        const efetuaLogin = (event) => {
            // Ignora o comportamento padrão do navegador (recarregar a página, por exemplo)
            event.preventDefault();

            // Remove a frase de erro do state erroMensagem e define que a requisição está em andamento
            setErroMensagem('') 
            setIsLoading(true)

            // Define a URL e o corpo da requisição
            axios.post('http://localhost:5000/api/Login', {
                email : email,
                senha : senha})

            // Verifica o retorno da requisição
            .then(resposta => {
                // Caso o status code seja 200,
                if (resposta.status === 200) {
                    // salva o token no localStorage,
                    localStorage.setItem('usuario-login', resposta.data.token);
                    // exibe o token no console do navegador
                    console.log('Meu token é: ' + resposta.data.token);
                    // e define que a requisição terminou
                    setIsLoading(false)

                    // Define a variável base64 que vai receber o payload do token
                    let base64 = localStorage.getItem('usuario-login').split('.')[1];
                    // Exibe no console o valor presente na variável base64
                    console.log(base64);
                    // Exibe no console o valor convertido de base64 para string
                    console.log(window.atob(base64));
                    // Exibe no console o valor convertido da string para JSON
                    console.log(JSON.parse(window.atob(base64)));

                        history.push('/CadastroEquipamento');
                        console.log('estou logado: ' + usuarioAutenticado());
                }
            })

            // Caso haja um erro,
            .catch(() => {
                // define o state erroMensagem com uma mensagem personalizada e que a requisição terminou
                setErroMensagem('E-mail ou senha inválidos! Tente novamente.') 
                setIsLoading(false)
            })
        }

        // Função genérica que atualiza o state de acordo com o input
        // pode ser reutilizada em vários inputs diferentes
        const atualizaStateCampoEmail = (campo) => {
            setEmail(campo.target.value)
        };

        const atualizaStateCampoSenha = (campo) => {
        setSenha(campo.target.value)
        };

    return (
        <div className="Login">

            <div className="Login__Container1">

                <div className="Login__Container2">

                    <img src={estoque1} className="Login__img" />

                </div>

                <form className="Login__Container3" onSubmit={efetuaLogin}>

                    <h1>Login</h1>
                    <div className="Login__conjunto">
                        <a1>Gerencie o patrimônio de sua escola utilizando nossos serviços!</a1>
                    </div>
                        <a>Seu Email</a>
                        <input
                            className='Login__input'
                            type='text'
                            name='email'
                            value={email}
                            onChange={atualizaStateCampoEmail}

                        />
                        <a>Sua Senha</a>
                        <input
                            type='password'
                            name='senha'
                            className='Login__input'
                            value={senha}
                            onChange={atualizaStateCampoSenha}
                        />
                        <p>{erroMensagem}</p>
                        <div className="Login__conjunto">
                            <input type="checkbox" id="scales" name="scales"
                            checked className="Login__checkbox"></input>
                            <a1>Mantenha-me conectado</a1>
                        </div>

                        {
                            // Caso seja true, renderiza o botão desabilitado com o texto 'Loading...'
                            isLoading === true &&
                            <div className="item">
                                <button className="Login__botao" type="submit" disabled>Carregando...</button>
                            </div>
                        }

                        {
                            isLoading === false &&
                            <div>
                                <button className="Login__botao" type="submit" disabled={email === '' || senha === '' ? 'none' : ''}>
                                Fazer Login
                                </button>
                            </div>
                        }

                        <div className='Login__conjunto1'>
                            <p>Ainda não tem uma conta? Cadastre-se!</p>
                            <p>Esqueceu a senha?</p>
                        </div>
                </form>
            </div>
        </div>

    );
}