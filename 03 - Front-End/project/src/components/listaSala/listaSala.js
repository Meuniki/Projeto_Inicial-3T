import React, { Component, useCallback, useState, useEffect } from 'react';

import './listaSala.css'
import api from '../../services/api';

export default function ListaSala() {

    const [listaSalas, setListaSalas] = useState([])

    useEffect(() => {
        api.get('/salas').then(resposta => setListaSalas(resposta.data));
        console.log(listaSalas)
    }, [])

    return (
        <div className='body-body-consulta'>
            <table>
                <tbody>
                    <tr>
                        <th>Instituição</th>
                        <th>Andar</th>
                        <th>Nome</th>
                        <th>Metragem da Sala</th>
                        <th>CEP</th>
                        <th>Telefone</th>
                    </tr>
                    {
                        listaSalas.map(sala => {
                            return (
                                <tr key={sala.idSala}>
                                    <td>{sala.instituicao}</td>
                                    <td>{sala.andar}</td>
                                    <td>{sala.nome}</td>
                                    <td>{sala.metragemSala}</td>
                                    <td>{sala.cep}</td>
                                    <td>{sala.telefone}</td>
                                </tr>
                            )
                        })
                    }
                </tbody>
            </table>
        </div>
    )
}