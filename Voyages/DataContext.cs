﻿namespace Voyages
{
    public class DataContext : IDataContext
    {
        public IEnumerable<Voyage> Voyages => new Voyage[] {
            new Voyage( "bandung"   , "bandung.jpg"     , "nature", "Se ressourcer en Indonésie"  , "en Indonésie"   , "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer elit lacus, faucibus a massa a, ultrices tempor magna."                     ),
            new Voyage( "santorini" , "santorini.jpg"   , "visite", "Les ruelles de Santorin"     , "en Grèce"       , "Curabitur feugiat at lectus sit amet tincidunt. Curabitur at eros nec turpis commodo luctus."                                                ),
            new Voyage( "derbyshire", "derbyshire.jpg"  , "nature", "Les lands du Derbyshire"     , "en Angleterre"  , "Phasellus mattis pretium sem, et gravida diam semper et. Duis pretium magna quis ornare pulvinar."                                           ),
            new Voyage( "kirkjufell", "kirkjufell.jpg"  , "nature", "L'Islande sauvage"           , "en Islande"     , "Donec convallis nunc nec sapien sodales, vel dignissim urna facilisis. In eget purus in ante facilisis commodo sit amet vitae lectus. "      ),
            new Voyage( "florence"  , "florence.jpg"    , "visite", "Escapade à Florence"         , "en Italie"      , "Donec a ex condimentum, lobortis sapien id, malesuada enim. Praesent sagittis nisi et enim bibendum finibus."                                ),
            new Voyage( "newyork"   , "newyork.jpg"     , "visite", "Croquez la pomme"            , "aux U.S.A"      , "Quisque sit amet libero tortor. Vivamus fermentum blandit odio in tincidunt."                                                                ),
            new Voyage( "kenya"     , "kenya.jpg"       , "nature", "Changer de faune"            , "au Kenya"       , "Aliquam nunc mi, molestie vel neque in, consequat volutpat ipsum. Pellentesque auctor maximus porta."                                        ),
            new Voyage( "chili"     , "chili.jpg"       , "nature", "La route des Andes"          , "au Chili"       , "Pellentesque lorem justo, posuere et sapien vel, iaculis volutpat est. Mauris sit amet dolor leo. Nam in commodo elit."                      ),
            new Voyage( "taipei"    , "taipei.jpg"      , "visite", "Les couleurs de Taipei"      , "à Taïwan"       , "Suspendisse dictum lobortis libero sit amet pulvinar. Mauris et congue ex, sed interdum nisl. Aenean ultrices turpis ac congue condimentum." ),
            new Voyage( "jusang"    , "jusang.jpg"      , "nature", "Automne en Corée"            , "en Corée"       , "Cras maximus sit amet nunc at tristique. Sed vitae tellus turpis. Curabitur quis magna dictum, posuere mi a, ornare dui."                    )
        };
    }
}
