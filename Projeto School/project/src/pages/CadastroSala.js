import '../assets/CSS/CadastroSala.css';
import imgUsuario from '../assets/Imagens/Vector.png';
import professor from '../assets/Imagens/professor.png';
import linha from '../assets/Imagens/Vector 45.png';
import linha2 from '../assets/Imagens/Line 1.png';
import React, { useState } from 'react';
import axios from 'axios';
import {parseJwt} from '../services/auth'

export default function CadastroSala() {

    const [ instituicao, setInstituicao ] = useState( '' );
    const [ andar, setAndar ] = useState( '' );
    const [ nome, setNome ] = useState( '' );
    const [ metragem, setMetragem ] = useState( 0.0 );
    const [ cep , setCep ] = useState( '' );
    const [ telefone , setTelefone ] = useState( '' );
    const [ isLoading, setIsLoading ] = useState( false );

    function cadastrarSala(event){
        event.preventDefault();

        setIsLoading(true);

        axios.post('http://localhost:5000/api/Salas',{
            instituicao : instituicao,
            andar : andar,
            nome : nome,
            metragemSala : metragem,
            cep : cep,
            telefone : telefone
        },
        {headers : {
            'Authorization' : 'Bearer ' + localStorage.getItem('usuario-login')
        }})
        .then(resposta => {
            if (resposta.status === 201) {
                console.log('Equipamento Cadastrado!');
                setIsLoading( false );
            }
        })

        .catch(erro => console.log(erro));
    };  

    return (
        <div className="pagina">
            <section>
                <div className="parteSuperior">
                    <div className="usuario">
                        <img src={linha2} alt="Linha" />
                        <img className="imgUsuario" src={imgUsuario} alt="Foto Do Usuário" />
                        <p className="nomeUsuario">{parseJwt().name}</p>
                    </div>
                </div>
                <div className="parteInferior">
                    <img className="professor" src={professor} alt="professor" />
                    <img src={linha} alt="Linha" />
                    <form className="blocoCadastro" onSubmit={cadastrarSala}>
                        <p className="titulo">Cadastro de salas</p>
                        <div>
                            <div className="bloco">
                                <p className="textoCadastro">Instituição:</p>
                                <input className="inputCadastro" type="text" value={instituicao} onChange={(event) => setInstituicao(event.target.value)}></input>
                            </div>
                            <div className="bloco">
                                <p className="textoCadastro">Andar:</p>
                                <input className="inputCadastro" type="text" value={andar} onChange={(event) => setAndar(event.target.value)}></input>
                            </div>
                            <div className="bloco">
                                <p className="textoCadastro">Nome:</p>
                                <input className="inputCadastro" type="text" value={nome} onChange={(event) => setNome(event.target.value)}></input>
                            </div>
                            <div className="bloco">
                                <p className="textoCadastro">Metragem:</p>
                                <input className="inputCadastro" type="float" value={metragem} onChange={(event) => setMetragem(event.target.value)}></input>
                            </div>
                            <div className="bloco">
                                <p className="textoCadastro">CEP:</p>
                                <input className="inputCadastro" type="text" value={cep} onChange={(event) => setCep(event.target.value)}></input>
                            </div>
                            <div className="bloco">
                                <p className="textoCadastro">Telefone:</p>
                                <input className="inputCadastro" type="text" value={telefone} onChange={(event) => setTelefone(event.target.value)}></input>
                            </div>
                    
                        </div>
                        <div className="areaBotao">
                            {
                                isLoading === false &&
                                <button className="botao" type="submit">Cadastrar</button>
                            }

                            {
                                isLoading === true &&
                                <button className="botao" type="submit" disabled>Carregando...</button>
                            }
                        </div>
                    </form>
                </div>
            </section>
        </div>
    );
}