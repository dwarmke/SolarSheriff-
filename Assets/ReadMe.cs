/* Start in the Mars scene. Clues send you to Luna then LEO.
 * 
 * You may get spammed with errors (immutable folder…) because of a change in version. Unity says they are working on it. 
 * 
 * This was originaly designed for a phone aspect ratio, which is why the buttons are stacked and backgrounds off center.
 * 
 * Most of the work is done by the ClueMaster script and ClueMaster prefab.
 * Create lists of clues in the script and then populate them in the inspector. 
 * Each clue will be preceded by a pronoun chosen under "suspect clues" in the ClueMaster prefab. 
 * Also under suspect clues you can direct indicate which scene comes next. 
 * Each of the locations does double duty by giving a clue and a difrent function. 
 * 
 * Right now there is no warrant, time keeping system, proper end (except for a text indicator), fail state (for wrong guesses) or randomization.
 * 
 */
