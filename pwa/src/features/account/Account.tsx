import React from 'react';
import { Route, Switch, useRouteMatch } from 'react-router';
import { useAppDispatch, useAppSelector } from '../../app/hooks';
import { selectAccount } from './accountSlice';
import Login from './Login';

function Account () {

    const count = useAppSelector(selectAccount);
    const dispatch = useAppDispatch();
    const { path } = useRouteMatch();

    return (
        <Switch>
            <Route exact path={`${path}/login`} component={Login} />
        </Switch>
    );

}

export default Account;