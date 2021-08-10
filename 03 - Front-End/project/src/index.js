// Import Pacotes
import React from 'react';
import ReactDOM from 'react-dom';
import { BrowserRouter as Router, Switch, Route, Redirect} from "react-router-dom";

// Import pages
import Cadastro from './pages/cadastro/cadastro'
import CadastroEquipamento from './pages/cadastroEquipamento/CadastroEquipamentos'
import CadastroSala from './pages/cadastroSala/CadastroSala'
import App from './pages/home/App';
import ListEquip from './pages/listEquip/ListEquip'
import ListSalas from './pages/listSalas/ListSala'
import Login from './pages/login/Login'
import { usuarioAutenticado } from './services/auth';

const Permissao = ({ component : Component  }) => (
  <Route 
    render = { props =>
      // Verifica se o usuário está logado
      usuarioAutenticado()? 
      // Se sim, renderiza de acordo com a rota solicitada e permitida
      <Component {...props} /> : 
      // Se não, redireciona para a página de login
      <Redirect to = '/' />
    }
  />
);

const routing = (
  <Router>
    <Switch>
      <Route path='/login' component={Login} />
      <Route path='/cadastro' component={Cadastro} />
      <Route exact path="/" component={App} />
      <Route path="/listarSalas" component={ListSalas} />
      <Route path="/listarequipamentos" component={ListEquip} />
      <Route path="/cadastroSala" component={CadastroSala} />
      <Route path="/cadastroEquipamento" component={CadastroEquipamento} />
      <Redirect to='/' />
    </Switch>
  </Router>
)

ReactDOM.render(routing, document.getElementById('root'));