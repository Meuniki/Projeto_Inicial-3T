import React, { Component, useCallback, useState, useEffect } from 'react';

import './listaEquip.css'
import api from '../../services/api';

export default function ListaEquip() {

    const [listaEquip, setListaEquip] = useState([])

    useEffect(() => {
        console.log('ola mundo')
        api.get('/Equipamentos').then(resposta => setListaEquip(resposta.data));
        console.log(listaEquip)
    }, [])

    return (
        <div className='body-body-consulta'>
            <table>
                <tbody>
                    <tr>
                        <th>Id Equipamento</th>
                        <th>Marca</th>
                        <th>Tipo Equipamento</th>
                        <th>Numero de Serie</th>
                        <th>Descrição</th>
                        <th>Numero Patrimonio</th>
                        <th>Ativo</th>
                    </tr>
                    {
                        listaEquip.map(equip => {
                            return (
                                <tr key={equip.idEquipamento}>
                                    <td>{equip.idEquipamento}</td>
                                    <td>{equip.marca}</td>
                                    <td>{equip.tipoEquipamento}</td>
                                    <td>{equip.numSerie}</td>
                                    <td>{equip.descricao}</td>
                                    <td>{equip.numPatrimonio}</td>
                                    <td></td>
                                </tr>
                            )
                        })
                    }
                </tbody>
            </table>
        </div>
    )
}