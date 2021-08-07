import '../pages/Login.css';
import estoque1 from '../../src/_images/estoque1.png';



function Login() {
  return (
    <div className="Login">

      <div className="Login__Container1">






        <div className="Login__Container2">

          <img src={estoque1} className="Login__img" />

        </div>







        <div className="Login__Container3">


          <h1>Login</h1>
          <div className="Login__conjunto">
            <a1>Gerencie o patrimônio de sua escola utilizando nossos serviços!</a1>
          </div>
          <a>Seu Email</a>
          <input
            className='Login__input'
            type='text'
            name='email'
          // value={this.state.Email}
          // onChange={this.atualizaStateCampo}

          />
          <a>Sua Senha</a>
          <input
            type='password'
            name='senha'
            className='Login__input'
          // value={this.state.senha}
          // onChange={this.atualizaStateCampo}
          />
          <div className="Login__conjunto">
            <input type="checkbox" id="scales" name="scales"
              checked className="Login__checkbox"></input>
            <a1>Mantenha-me conectado</a1>
          </div>
          <button type='button' className='Login__botao'>
            Fazer Login
          </button>




          <div className='Login__conjunto1'>
            <p>Ainda não tem uma conta? Cadastre-se!</p>
            <p>Esqueceu a senha?</p>
          </div>

      
        </div>
      </div>
    </div>

  );
}

export default Login;
