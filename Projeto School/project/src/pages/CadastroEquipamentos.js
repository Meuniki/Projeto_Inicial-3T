import "../assets/CSS/CadastroEquipamentos.css";
import imgUsuario from "../assets/Imagens/Vector.png"
import livros from "../assets/Imagens/Livros.png"
import linha from "../assets/Imagens/Vector 45.png"
import linha2 from "../assets/Imagens/Line 1.png"
import React, { useState } from 'react';
import axios from 'axios';
import {parseJwt} from '../services/auth'

export default function CadastroEquipamentos() {

    const [ marca, setMarca ] = useState( '' );
    const [ tipoEquipamento, setTipoEquipamento ] = useState( '' );
    const [ numSerie, setNumSerie ] = useState( '' );
    const [ ativo , setAtivo ] = useState( false );
    const [ numPatrimonio , setNumPatrimonio ] = useState( '' );
    const [ descricao, setDescricao ] = useState( '' );
    const [ isLoading, setIsLoading ] = useState( false );

    function cadastrarEquipamento(event){
        event.preventDefault();

        setIsLoading(true);

        axios.post('http://localhost:5000/api/Equipamentos',{
            marca : marca,
            tipoEquipamento : tipoEquipamento,
            numSerie : numSerie,
            descricao : descricao,
            numPatrimonio : numPatrimonio,
            ativo : ativo
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
    
    return(
        <div className="pagina">
            <section>
                <div className="parteSuperior">
                    <div className="usuario">
                        <img src={linha2} alt="Linha"/>
                        <img className="imgUsuario" src={imgUsuario} alt="Foto Do Usuário"/>
                        <p className="nomeUsuario">{parseJwt().name}</p>
                    </div>
                </div>
                <div className="parteInferior">
                    <img className="livros" src={livros} alt="Livros"/>
                    <img src={linha} alt="Linha"/>
                    <form className="blocoCadastro" onSubmit={cadastrarEquipamento}>
                        <p className="titulo">Cadastro de equipamentos</p>
                        <div>
                            <div className="bloco">
                                <p className="textoCadastro">Marca:</p>
                                <input className="inputCadastro" type="text" value={marca} onChange={(event) => setMarca(event.target.value)}></input>
                            </div>
                            <div className="bloco">
                                <p className="textoCadastro">Tipo de equipamento:</p>
                                <input className="inputCadastro" type="text" value={tipoEquipamento} onChange={(event) => setTipoEquipamento(event.target.value)}></input>
                            </div>
                            <div className="bloco">
                                <p className="textoCadastro">Numero de série:</p>
                                <input className="inputCadastro" type="text" value={numSerie} onChange={(event) => setNumSerie(event.target.value)}></input>
                            </div>
                            <div className="bloco">
                                <p className="textoCadastro">Ativo/Inativo:</p>
                                <input className="inputCadastro" type="boolean" value={ativo} onChange={(event) => setAtivo(event.target.value)}></input>
                            </div>
                            <div className="bloco">
                                <p className="textoCadastro">Número de patrimônio:</p>
                                <input className="inputCadastro" type="text" value={numPatrimonio} onChange={(event) => setNumPatrimonio(event.target.value)}></input>
                            </div>
                            <div className="bloco">
                                <p className="textoCadastro">Descrição:</p>
                                <input className="inputCadastro" type="text" value={descricao} onChange={(event) => setDescricao(event.target.value)}></input>
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
    )
}