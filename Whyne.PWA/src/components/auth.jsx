const FooBarForm = () => {
    const [formData, updateFormData] = React.useState(initialFormData);
  
    const handleChange = (e) => {
      updateFormData({
        ...formData,
  
        // Trimming any whitespace
        [e.target.name]: e.target.value.trim()
      });
    };
  
    const handleSubmit = (e) => {
      e.preventDefault()
      console.log(formData);
      // ... submit to API or something
    };
  
    return (
      <>
        <li id="Index" ><a href="index.html"> ⇐ Retour</a></li>

        <h1>Créer votre compte</h1>
            <div class="form">
                <form>
                    <label>Nom d'utilisateur </label><br />
                    <input type="text" name="username" onChange={handleChange}/>
                    <br />
                    <label>Email </label><br />
                    <input type="email" name="email" onChange={handleChange}/>
                    <br />
                    <label>Mot de passe:</label><br />
                    <input type="password" name="pwd" onChange={handleChange}/>
                    <br /><br />
                    <input type="submit" value="submit" onClick={handleSubmit}/>
                </form>
            </div>
      </>
    );
  };