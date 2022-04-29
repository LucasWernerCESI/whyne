import React, { useState } from 'react'
import { Link } from 'react-router-dom'
// import fetch from 'node-fetch'

export default function Login () {
  const [email, setEmail] = useState()
  const [password, setPassword] = useState()

  const onFormSubmit = e => {
    e.preventDefault()
    console.log(email)
    console.log(password)
    // change it later;
  }

  // const login = async (e) => {
  //   e.preventDefault()
  //   await post('https://localhost:44373/api/Auth/Login', { email, password })
  // }

  const login = fetch('https://localhost:44373/api/Auth/Login', { email, password })
    .then(response => response.json())
    .then(data => console.log(data))

  return (
    <div>
      <br />
      <div className='form'>
        <Link to='/'>⇐ Retour</Link>
        <form>
          <h2>Connectez vous</h2><br /><br />
          <label>Email </label>
          <input type='email' name='email' onChange={e => { setEmail(e.target.value) }} />
          <br />
          <label>Mot de passe</label>
          <input type='password' name='password' onChange={e => { setPassword(e.target.value) }} />
          <br /><br />
          <input type='submit' value='submit' onclick={login} />
        </form>
      </div>
    </div>
  )
}
