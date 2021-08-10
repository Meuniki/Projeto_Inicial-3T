import './ListEquip.css'

import Header from '../../components/header/header'
import SideBarMenu from '../../components/sitebarMenu/sideBarMenu';
import Consultas from '../../components/listaEquipamentos/listaEquip';

export default function ListSala() {
    return (
        <div className="body-content">
            <SideBarMenu />
            <div className="page-content">
                <Header />
                <div className="body-page-consulta">
                    <div className='body-header-consulta'>
                        <div className='body-header-content'>
                            <h1>Equipamentos</h1>
                            <div className='filter'>
                                {/* <img src={funil} alt="dashboard-icon" /> */}
                                <p>Filtro: Meu Funil</p>
                                {/* <img src={arrowDown} alt="dashboard-icon" /> */}
                            </div>
                        </div>
                    </div>
                    <Consultas />
                </div>
            </div>
        </div>
    )
}