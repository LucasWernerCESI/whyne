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
          Icon: '',
          Title: 'Saint-Emilion Grand Cru AOC',
          Decription: 'no description',
          DegreeAlcoolo: '14,5',
          Familly: 'BORDEAU',
          Quantity: '30',
          Provider: "CHÂTEAU TAUZINAT L'HERMITAGE",
          Price: '20'
        },
        {
          Id: '2',
          Icon: '',
          Title: 'Aude Hauterive IGP',
          Descirption: 'no desc',
          DegreeAlcoolo: '14',
          Familly: 'CIGALUS BLANC',
          Quantity: '0',
          Provider: 'GERARD BERTRAND',
          Price: '35'
}]
    },
    {
      Section: 'Vins Pétillants',
      Liste: [
        {
          Id: '3',
          Icon: '',
          Title: 'Champagne Rosé Yveline Prat',
          Decription: 'un pinot noir test',
          DegreeAlcoolo: '',
          Familly: 'CHAMPAGNE ROSÉ',
          Quantity: '30',
          Provider: 'YVELINE PRAT',
          Price: '19'
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
