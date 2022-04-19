import { yupResolver } from '@hookform/resolvers/yup';
import React from 'react';
import { useForm } from 'react-hook-form';
import * as yup from 'yup';
import { useAppDispatch, useAppSelector } from '../../app/hooks';
import { loginAsync, selectAccount } from './accountSlice';

interface ILoginFormInput {
    email: string;
    password: string;
};

const schema = yup.object({
    email: yup.string().required().email(),
    password: yup.string().required()
}).required();

function Login() {

    const account = useAppSelector(selectAccount);
    const dispatch = useAppDispatch();

    const { register, formState: { errors }, handleSubmit, } = useForm<ILoginFormInput>({ resolver: yupResolver(schema) });
    const onSubmit = (data: ILoginFormInput) => {
        dispatch(loginAsync(JSON.stringify(data)));
    };

    return (
        <>
            { account && account.firstName }
            <form onSubmit={handleSubmit(onSubmit)} noValidate>
                <input {...register('email')} type="text"></input>
                {errors.email && errors.email.message}
                <br />
                <input {...register('password')} type="text"></input>
                {errors.password && errors.password.message}
                <br />
                <button type="submit">Soumettre</button>
            </form>
        </>
    );
}

export default Login;