import './App.css'
import ProductList from './components/ProductList'
import Hearder from './components/Header'
import {useEffect, UserState} from 'react'
import React from 'react'

let connect = false

function App() {
  const MultiListeVin = [
    { Section: 'Vins', 
      Liste: [
        { 
          Id: '1', 
          Icon: '', 
          Title: 'pinot noir', 
          Decription: 'un pinot noir test', 
          DegreeAlcoolo: '', 
          Familly: 'Pinot', 
          Quantity: '30', 
          Provider: 'maison', 
          Price: '19.95' }, 
        { Id: '2', Icon: '', Title: 'vin rouge', Descirption: 'no desc', DegreeAlcoolo: '', Familly: 'Vin', Quantity: '0', Provider: 'no provider', Price: '15' }] }, 
    { Section: 'Vins Pétillants', 
      Liste: [
        { Id: '3', Icon: '', Title: 'pinot noir', Decription: 'un pinot noir test', DegreeAlcoolo: '', Familly: 'Pinot', Quantity: '30', Provider: 'maison', Price: '19.95' }] }]

  // useEffect(async () => {
  //   const response = await fetch("https://localhost:44373/api/Customers");
  //   const data = await response.json();
  //   console.log(data)
  // })


  fetch('https://localhost:44373/api/Wines')
    .then(response => response.json())
    .then(data => console.log(data));


      
  if (connect) {
    return (
      <>    
      <header>
        <div id="header-scroll">
          <div className="container">
            <div className="row">
              <div className="col-md-2">
                <h2><a href="#">Whyne</a></h2>
                </div>

                <div className="col-md-8">
                    <nav>
                      <ul>
                        {MultiListeVin.map((product) => <Hearder section={product} />)}
                      </ul>
                    </nav>
                  </div>

                  <div className="col-md-2">
                    <div className="dropdown">
                      <i className='fa fa-user-o user'></i>
                      <div className="dropdown-content">
                        <li id="Login"><a href='#'>Votre Profil</a></li>
                        <li id="Signin"><a href="#">Se déconnecter</a></li>
                      </div>
                    </div>
                  </div>
                    
            </div>
          </div>
        </div>
      </header>
      
      {MultiListeVin.map((product) => <ProductList section={product} />)}
      </>
    )
  }
  else{
    return (
      <>    
      <header>
        <div id="header-scroll">
          <div className="container">
            <div className="row">
              <div className="col-md-2">
                <h2><a href="#">Whyne</a></h2>
                </div>

                <div className="col-md-8">
                    <nav>
                      <ul>
                        {MultiListeVin.map((product) => <Hearder section={product} />)}
                      </ul>
                    </nav>
                  </div>

                  <div className="col-md-2">
                    <div className="dropdown">
                      <i className='fa fa-user-o user'></i>
                      <div className="dropdown-content">
                        <li id="Login"><a href="Login.html">Se connecter</a></li>
                        <li id="Signin"><a href="CreateAccount.html">Créer un compte</a></li>
                      </div>
                    </div>
                  </div>
                    
            </div>
          </div>
        </div>
      </header>
      
      {MultiListeVin.map((product) => <ProductList section={product} />)}
      </>
    )
  }
}

export default App
