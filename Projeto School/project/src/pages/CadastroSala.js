import '../pages/CadastroSala.css';
import imgUsuario from '../../src/_images/Vector.png';
import professor from '../../src/_images/professor.png';
import linha from '../../src/_images/Vector 45.png';
import linha2 from '../../src/_images/Line 1.png';
// import React, { useState } from 'react';
// import axios from 'axios';



function Sala() {
    return (
        <div className="pagina">
            <section>
                <div className="parteSuperior">
                    <div className="usuario">
                        <img src={linha2} alt="Linha" />
                        <img className="imgUsuario" src={imgUsuario} alt="Foto Do Usuário" />
                        <p className="nomeUsuario">Vinicius - Adm</p>
                    </div>
                </div>
                <div className="parteInferior">
                    <img className="professor" src={professor} alt="professor" />
                    <img src={linha} alt="Linha" />
                    <form className="blocoCadastro">
                        <p className="titulo">Cadastro de salas</p>
                        <div>
                            <div className="bloco">
                                <p className="textoCadastro">Instituição:</p>
                                <input className="inputCadastro" type="text" ></input>
                            </div>
                            <div className="bloco">
                                <p className="textoCadastro">Andar:</p>
                                <input className="inputCadastro" type="text"  ></input>
                            </div>
                            <div className="bloco">
                                <p className="textoCadastro">Metragem:</p>
                                <input className="inputCadastro" type="float"  ></input>
                            </div>
                            <div className="bloco">
                                <p className="textoCadastro">CEP:</p>
                                <input className="inputCadastro" type="text"  ></input>
                            </div>
                            <div className="bloco">
                                <p className="textoCadastro">Telefone:</p>
                                <input className="inputCadastro" type="text" ></input>
                            </div>
                    
                        </div>
                        <div className="areaBotao">
                            {

                                <button className="botao" type="submit">Cadastrar</button>
                            }

                            {

                                <button className="botao" type="submit" disabled>Carregando...</button>
                            }
                        </div>
                    </form>
                </div>
            </section>
        </div>
    );
}

export default Sala;