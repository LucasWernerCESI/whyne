import React from 'react';
import { Route, Switch } from 'react-router';
import Account from '../../features/account/Account';
import { Counter } from '../../features/counter/Counter';

function Router() {

    return (
        <Switch>
            <Route exact path="/" component={Counter} />
            <Route path="/account" component={Account} />
        </Switch>
    );

}

export default Router;