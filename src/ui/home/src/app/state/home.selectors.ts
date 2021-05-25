import { createFeatureSelector, createSelector } from '@ngrx/store';
import { LayoutState } from './home.state';

export const featureSelector = createFeatureSelector<LayoutState>('layout');
export const screenWeight = createSelector(featureSelector, state => state.screenWeight);
