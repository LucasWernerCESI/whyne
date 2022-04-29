import React, { useEffect, useState } from 'react'
// import fetch from 'node-fetch'
import Header from './navigation/Header'
import Footer from './navigation/Footer'
import ProductList from './products/ProductList'

// const GetWines = fetch('https://localhost:44373/api/Wines').then(response => response.json())

// fetch('https://localhost:44373/api/Wines')
//   .then(response => response.json())
//   .then(data => console.log(data))

export default function Home () {
  const MultiListeVin = [
    {
      Section: 'Vins',
      Liste: [
        {
          Id: '1',
          Icon: 'https://www.vinatis.com/59028-detail_default/ampelomeryx-rouge-2020-domaine-pellehaut.png',
          Title: 'AMPELOMERYX ROUGE 2020',
          Description: "Superbement travaillé, ce vin est une véritable bombe aromatique! L'ampéloméryx, un nom complexe pour un vin qui l'est encore plus !",
          DegreeAlcoolo: '12,5',
          Familly: 'VIN ROUGE',
          Quantity: '30',
          Provider: 'DOMAINE PELLEHAUT',
          Price: '11'
        },
        {
          Id: '2',
          Icon: 'https://www.vinatis.com/64723-detail_default/reserve-2020-domaine-tariquet.png',
          Title: 'RESERVE 2020',
          Description: 'Le Domaine Tariquet se place une nouvelle fois sur un excellent rapport qualité-prix avec cette cuvée élevée 6 mois en fûts : le résultat est élégant !',
          DegreeAlcoolo: '9',
          Familly: 'VIN BLANC',
          Quantity: '0',
          Provider: 'DOMAINE TARIQUET',
          Price: '9'
        },
        {
          Id: '3',
          Icon: 'https://www.vinatis.com/60319-detail_default/l-imprevu-2020-domaine-tariquet.png',
          Title: "L'IMPRÉVU 2020",
          Description: "L'imprévu est un assemblage inédit de Riesling, planté en 2010, et d’Ugni Blanc, cépage historique du domaine. Un vin blanc sec, léger et harmonieux, structuré et équilibré, aromatique et délicat qui pourra ravir les consommateurs en quête de nouvelles expériences gustatives. Une bouteille entièrement sérigraphiée, une présentation pure, sobre et élégante.",
          DegreeAlcoolo: '9,5',
          Familly: 'VIN BLANC',
          Quantity: '99',
          Provider: 'DOMAINE TARIQUET',
          Price: '10'
        }
      ]
    },
    {
      Section: 'Vins Pétillants',
      Liste: [
        {
          Id: '4',
          Icon: 'https://www.vinatis.com/65880-detail_default/pilaho-2021-domaine-pellehaut.png',
          Title: 'PILAHO 2021',
          Description: 'Faiblement alcoolisé, naturellement sucré et délicatement pétillant, découvrez cette bombe aromatique sans plus attendre !',
          DegreeAlcoolo: '9',
          Familly: 'VIN DE FRANCE',
          Quantity: '0',
          Provider: 'DOMAINE PELLEHAUT',
          Price: '10'
        }]
    }]

  return (
    <div>
      <Header />
      {MultiListeVin.map((product, i) => <ProductList section={product} key={i} />)}
      {/* {GetWines.map((product, i) => <ProductList section={product} key={i} />)} */}
      <Footer />
    </div>
  )
}
