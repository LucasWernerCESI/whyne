import React from 'react'
import { BrowserRouter as Router, Route, Link, Routes } from "react-router-dom"

export default function Footer(){
    return(
        <footer>
        <div className="footer-bottom">
          <div className="container">
            <div className="row">
  
              <div className="col-md-3">
                <div>2021 © <a href="#">Whyne </a></div>
              </div>

              <div className="col-md-6">
                <nav>
                  <ul id="footer-menu">
                    <li><Link to="History">Notre histoire</Link></li>
                    <li><Link to="/">Nous Contacter</Link></li>
                    <li id="Disclaimers"><a href='https://www.santepubliquefrance.fr/determinants-de-sante/alcool/articles/quels-sont-les-risques-de-la-consommation-d-alcool-pour-la-sante' target="_blank">Disclaimers</a></li>
                  </ul>
                </nav>
              </div>
  
              <div className="col-md-3">
                    <a href="#" target="_blank" title="Facebook" className="socials-item">
                      <i className="fab fa-facebook-f facebook"></i>
                    </a>
                    <a href="#" target="_blank" title="Twitter" className="socials-item">
                      <i className="fab fa-twitter twitter"></i>
                    </a>
              </div>
              
            </div>
          </div>
        </div>
      </footer>
    )
}