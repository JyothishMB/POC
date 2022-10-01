import React from 'react';
import './App.css';
import Expenses from './components/Expenses/Expenses';

function App() {
  const expenseslist = [
    {
      id: 1,
      title: 'Parker Pen',
      amount: 30,
      date: new Date(2023, 4, 29)
    },
    {
      id: 1,
      title: 'Swis Knife',
      amount: 400,
      date: new Date(2023, 3, 21)
    },
    {
      id: 1,
      title: 'Trecking Pants',
      amount: 500,
      date: new Date(2023, 2, 16)
    }
  ]
  return (
    <div>
      <h2>Lets get started</h2>
      <Expenses expenses={expenseslist}/>
    </div>
  );
}

export default App;
