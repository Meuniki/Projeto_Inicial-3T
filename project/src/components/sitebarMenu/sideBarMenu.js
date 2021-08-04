import { Link } from "react-router-dom";

import './sideBarMenu.css';

import logo from '../../assets/img/logo.png'
import dashboard from '../../assets/img/dashboard.png'
import salas from '../../assets/img/sala.png'
import equipamentos from '../../assets/img/equipamentos.png'

export default function sideBarMenu() {
    return (
        <div className="nav-left-content">

            <div className="icon-header">
                <Link to="/"><img src={logo} alt="dashboard-icon" /></Link>
                <hr />
            </div>

            <div className="icon">
                <Link to="/"><img src={dashboard} alt="dashboard-icon" /></Link>
            </div>

            <div className="icon">
                <a href=''><img src={salas} alt="sala-icon" /></a>
            </div>

            <div className="icon">
                <Link to="/consulta"><img src={equipamentos} alt="equipamento-icon" /></Link>
            </div>
        </div>
    )
}