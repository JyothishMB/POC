import React from 'react';
import './App.css';
import Expenses from './components/Expenses/Expenses';
import NewExpense from './components/NewExpense/NewExpense';

function App() {
  const expenseslist = [
    {
      id: 1,
      title: 'Parker Pen',
      amount: 30,
      date: new Date(2022, 4, 29)
    },
    {
      id: 2,
      title: 'Swis Knife',
      amount: 400,
      date: new Date(2022, 3, 21)
    },
    {
      id: 3,
      title: 'Trecking Pants',
      amount: 500,
      date: new Date(2022, 2, 16)
    },
    {
      id: 4,
      title: 'Camping Kit',
      amount: 500,
      date: new Date(2021, 2, 16)
    }
  ];

  const addExpenseHandler = expense => {
    console.log('In App.js');
    console.log(expense);
  };


  return (
    <div>
      <NewExpense onAddExpense={addExpenseHandler}/>
      <Expenses expenses={expenseslist}/>
    </div>
  );
}

export default App;
