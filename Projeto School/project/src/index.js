import React from 'react';
import ReactDOM from 'react-dom';
import { Route, BrowserRouter as Router, Switch, Redirect } from 'react-router-dom';
import CadastroEquipamentos from './pages/CadastroEquipamentos';
import CadastroSala from './pages/CadastroSala';
import Login from './pages/Login';
import reportWebVitals from './reportWebVitals';
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
    <div>
        <Switch>
          <Route exact path="/" component={Login}/>
          <Permissao path="/CadastroSala" component={CadastroSala}/>
          <Permissao path="/CadastroEquipamentos" component={CadastroEquipamentos}/>
        </Switch>
    </div>
  </Router>
);

ReactDOM.render( routing, document.getElementById('root'));

// If you want to start measuring performance in your app, pass a function
// to log results (for example: reportWebVitals(console.log))
// or send to an analytics endpoint. Learn more: https://bit.ly/CRA-vitals
reportWebVitals();
