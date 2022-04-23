import './App.css'
import { BrowserRouter as Router, Route, Link, Routes } from "react-router-dom"
import React from 'react'
import Home from './components/home'
import Login from './components/authentification/Login'
import Signin from './components/authentification/Signin'
import History from './components/other/History'
import Cart from './components/user/Cart'
import Profile from './components/user/Profile'


function App() {
    return (
        <Router>
          <Routes>
            <Route path="/" element={<Home />} />
            <Route path="/signin" element={<Signin />} />
            <Route path="/login" element={<Login />} />
            <Route path="/history" element={<History />} />
            <Route path="/cart" element={<Cart />} />
            <Route path="/profile" element={<Profile />} />
          </Routes>
        </Router>
    )}

export default App
