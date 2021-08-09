import '../pages/Login.css';
import estoque1 from '../../src/_images/estoque1.png';

// class Login extends Component {


//   constructor(props) {
//     super(props);
//     this.state = {
//       email: '',
//       senha: '',
//       erroMensagem: '',
//       /*isLoading: false*/
//     }
//   }

//   efetuaLogin = (event) => {

//     event.preventDefault();

//     //remove a frase do state erroMensagem
//     this.setState({ erroMensagem: ''/*isLoading: true*/ })

//     axios.post('http://localhost:5000/api/Login', {
//       email: this.state.email,
//       senha: this.state.senha
//     })

//       // Verifica o retorno da requisição
//       .then(resposta => {
//         // Caso o status code seja 200,
//         if (resposta.status === 200) {
//           // salva o token no localStorage,
//           localStorage.setItem('usuario-login', resposta.data.token);
//           // exibe o token no console do navegador
//           console.log('Meu token é: ' + resposta.data.token);
//           // e define que a requisição terminou
//           this.setState({ isLoading: false })

//           // Define a variável base64 que vai receber o payload do token
//           let base64 = localStorage.getItem('usuario-login').split('.')[1];
//           // Exibe no console o valor presente na variável base64
//           console.log(base64);
//           // Exibe no console o valor convertido de base64 para string
//           console.log(window.atob(base64));
//           // Exibe no console o valor convertido da string para JSON
//           console.log(JSON.parse(window.atob(base64)));

//           // Exibe no console apenas o tipo de usuário logado
//           console.log(parseJwt().role);

//           // Verifica se o tipo de usuário logado é Administrador
         
//           // if (parseJwt().role === '1') {
//           //   this.props.history.push('/Adm');
//           //   console.log('estou logado: ' + usuarioAutenticado());
//           // }

//           switch (parseJwt().role) {
//             case '1':
//                 this.props.history.push('/Adm');
//                 break;

//             case '2':
//                 this.props.history.push('/Paciente');
//                 break;

//             case '3':
//                 this.props.history.push('/Medico');
//                 break;
        
//             default:
//                 this.props.history.push('/');
//                 break;
//         }
//         }



//       })

//       //caso o usuario erre a senha ou email,
//       .catch(() => {

//         //define o valor do state erroMensagem como uma mensagem personalizada
//         this.setState({ erroMensagem: 'E-mail ou senha inválidos! Tente novamente.', /*isload: true*/ })
//       })

//   }

//   atualizaStateCampo = (campo) => {
//     this.setState({ [campo.target.name]: campo.target.value })
//   }


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
          <button type='submit' className='Login__botao'>
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
