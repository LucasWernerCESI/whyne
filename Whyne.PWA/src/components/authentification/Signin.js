import React, { useState } from 'react'
import { Link } from 'react-router-dom'
// import fetch from 'node-fetch'

export default function Signin () {
  const [username, setUsername] = useState()
  const [email, setEmail] = useState()
  const [password, setPassword] = useState()

  const onFormSubmit = e => {
    e.preventDefault()
    console.log(username)
    console.log(email)
    console.log(password)
    // change it later;
  }

  fetch('https://localhost:44373/api/Auth/Register', { email, password })
    .then(response => response.json())
    .then(data => console.log(data))

  return (
    <div>
      <br />
      <div className='form'>
        <Link to='/'>⇐ Retour</Link>
        <form>
          <h2>Créer votre compte</h2> <br /><br />
          <label>Nom d'utilisateur </label>
          <input type='text' name='username' onChange={e => { setUsername(e.target.value) }} />
          <br />
          <label>Email </label>
          <input type='email' name='email' onChange={e => { setEmail(e.target.value) }} />
          <br />
          <label>Mot de passe</label>
          <input type='password' name='password' onChange={e => { setPassword(e.target.value) }} />
          <br /><br />
          <input type='submit' value='submit' />
        </form>
      </div>
    </div>
  )
}
