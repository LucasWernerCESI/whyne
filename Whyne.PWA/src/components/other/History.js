import { BrowserRouter as Router, Route, Link, Routes } from "react-router-dom"

export default function History() {
  
    return (     
    <div>
        <Link to="/">⇐ Retour</Link>

        <h2>Notre Histoire</h2>
        <p>Nous n'en avons pas encore.
          Mais espérons la créer grâce à vous.
        </p>

    </div> 
  );
}