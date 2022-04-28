import React, { useState } from 'react'
import { Link } from 'react-router-dom'

export default function Login () {
  const [email, setEmail] = useState()
  const [password, setPassword] = useState()

  const onFormSubmit = e => {
    e.preventDefault()
    console.log(email)
    console.log(password)
    // change it later;
  }

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
          <input type='submit' value='submit' />
        </form>
      </div>
    </div>
  )
}
