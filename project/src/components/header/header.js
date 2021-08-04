import '../header/header.css'

import plus from '../../assets/img/plus.png'
import user from '../../assets/img/user.png'

export default function Header() {

    return (
        <header className="header-page">
            <div className="btn-new">
                <img src={plus} alt="plus" />
                <p>Novo</p>
            </div>
            <div className="header-menu">
                <hr />
                <div className="user">
                    <img src={user} alt="Usuario" />
                    <p>Rafael Gomes - Adm</p>
                </div>
            </div>
        </header>
    )
}