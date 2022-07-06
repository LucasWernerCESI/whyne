import React from 'react'
import { Link } from 'react-router-dom'
import NavBar from './NavBar'
import { MultiListeVin, GetWines } from '../home'

const connected = false

export default function Header () {
  if (connected) {
    return (
      <header>
        <div id='header-scroll'>
          <div className='container'>
            <div className='row'>
              <div className='col-md-2'>
                <h2><Link to='/'>Whyne</Link></h2>
              </div>

              <div className='col-md-8'>
                <nav>
                  <ul>
                    <li><a href='#Vins'>Vins</a></li>
                    <li><a href='#Vins Pétillants'>Vins Pétillants</a></li>
                    <li><a href='#Bières'>Bières Artisanales</a></li>
                    <li><a href='#Vins'>Autre</a></li>
                    {/* {MultiListeVin.map((product) => <NavBar section={product} />)} */}
                  </ul>
                </nav>
              </div>

              <div className='col-md-2'>
                <Link to='Cart' className='fas fa-shopping-basket' />
                <div className='dropdown'>
                  <i className='fas fa-user-circle' />
                  <div className='dropdown-content'>
                    <Link to='Profile'>Se connecter</Link>
                    <br />
                    <Link to='/'>Se déconnecter</Link>
                  </div>
                </div>
              </div>

            </div>
          </div>
        </div>
      </header>
    )
  } else {
    return (
      <header>
        <div id='header-scroll'>
          <div className='container'>
            <div className='row'>
              <div className='col-md-2'>
                <h2><a href='#'>Whyne</a></h2>
              </div>

              <div className='col-md-8'>
                <nav>
                  <ul>
                    <li><a href='#Vins'>Vins</a></li>
                    <li><a href='#Vins Pétillants'>Vins Pétillants</a></li>
                    <li><a href='#Bières'>Bières Artisanales</a></li>
                    <li><a href='#Vins'>Autre</a></li>

                    {/* map de multilistvin fait crash */}
                    {/* <NavBar section={MultiListeVin} /> */}
                    {/* {MultiListeVin.map((product) => <NavBar section={product} />)} */}
                    {/* {MultiListeVin.map((product) => <NavBar section={product} />)} */}
                    {/* {MultiListeVin.map((product, i) => <NavBar section={product} key={i} />)} */}
                  </ul>
                </nav>
              </div>

              <div className='col-md-2'>
                <div className='dropdown'>
                  <i className='fas fa-user-circle' />
                  <div className='dropdown-content'>
                    <Link to='Login'>Se connecter</Link>
                    <br />
                    <Link to='Signin'>Créer un compte</Link>
                  </div>
                </div>
              </div>

            </div>
          </div>
        </div>
      </header>
    )
  }
}
