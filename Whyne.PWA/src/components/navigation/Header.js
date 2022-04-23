import React from 'react'
import { BrowserRouter as Router, Route, Link, Routes } from "react-router-dom"
import NavBar from './NavBar'
import MultiListeVin from '../home'

let connected = true

export default function Header(){
    if (connected){
        return(
            <header>
            <div id="header-scroll">
            <div className="container">
                <div className="row">
                <div className="col-md-2">
                    <h2><Link to="/">Whyne</Link></h2>
                    </div>

                    <div className="col-md-8">
                        <nav>
                        <ul>
                            {/* {MultiListeVin.map((product) => <NavBar section={product} />)} */}
                        </ul>
                        </nav>
                    </div>

                    <div className="col-md-2">
                    <Link to="Cart" className="fas fa-shopping-basket"></Link>
                        <div className="dropdown">
                            <i className='fas fa-user-circle'></i>
                            <div className="dropdown-content">
                                <Link to="Profile">Se connecter</Link>
                                <br></br>
                                <Link to="/">Se déconnecter</Link>
                            </div>
                        </div>
                    </div>
                        
                </div>
            </div>
            </div>
        </header>
        )}
    else{
        return(
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
                        {/* {MultiListeVin.map((product) => <NavBar section={product} />)} */}
                        </ul>
                        </nav>
                    </div>

                    <div className="col-md-2">
                        <div className="dropdown">
                        <i className='fa fa-user-o user'></i>
                        <div className="dropdown-content">
                            <Link to="Login">Se connecter</Link>
                            <br></br>
                            <Link to="Signin">Créer un compte</Link>
                        </div>
                        </div>
                    </div>
                        
                </div>
            </div>
            </div>
        </header>
    )}
}