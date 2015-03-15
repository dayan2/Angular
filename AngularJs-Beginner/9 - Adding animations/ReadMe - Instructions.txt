find u need to add some code in to the css file:
.artistlist li {
  margin: 0;
  padding: 10px 10px 0 10px;
  border-bottom: 1px dotted black;
  opacity: .9;
  -webkit-transition:all 0.3sec ease-out;
  -moz-transition:all 0.3sec ease-out;
  -o-transition:all 0.3sec ease-out;
  transition:all 0.3sec ease-out;
}
.artistlist li:hover {
  background: #FDF6E3;
  opacity: 1;
  -webkit-transform: scale(1.2);
  -moz-transform: scale(1.2);
  -o-transform: scale(1.2);
  transform: scale(1.2);
}


you could also go to the angularJs.org and download the animation javascript CDN,
https://code.angularjs.org/1.2.28/angular-animate.min.js

And do some animation with that as well:

1. Go and see i have put da 'ngAnimate' as a dependency in the controller.js
2. then go to the place you want to add the animation in this case in my list.html file inside the <li> tag, i'm going to
add this following tage:
<li ng-animate="'animate'" class="artist cf" ng-repeat="image in artists | filter:query | orderBy:ArtistOrder : direction"> 

3.paste this in the bottom of the css file:

.artist.ng-enter.ng-enter-active,
.artist.ng-leave{
  opacity:1;
  height: 80px;
  overflow: hidden;
}

.artist.ng-leave.ng-leave-active,
.artist.ng-enter{
  opacity:0;
  height: 0;
  overflow: hidden;
}

this dosen't change anything though.....