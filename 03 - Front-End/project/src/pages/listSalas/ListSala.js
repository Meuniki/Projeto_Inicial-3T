import './ListSala.css'

import Header from '../../components/header/header'
import SideBarMenu from '../../components/sitebarMenu/sideBarMenu';
import Salas from '../../components/listaSala/listaSala';

export default function ListSala() {
    return (
        <div className="body-content">
            <SideBarMenu />
            <div className="page-content">
                <Header />
                <div className="body-page-sala">
                    <div className='body-header-sala'>
                        <div className='body-header-content'>
                            <h1>Salas</h1>
                            <div className='filter'>
                                {/* <img src={funil} alt="dashboard-icon" /> */}
                                <p>Filtro: Meu Funil</p>
                                {/* <img src={arrowDown} alt="dashboard-icon" /> */}
                            </div>
                        </div>
                    </div>
                    <Salas />
                </div>
            </div>
        </div>
    )
}