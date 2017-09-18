
namespace EncyclopedieWakfu.Models
{
    public class Classe
    {
        public string name { get; set; }
        public string description { get; set; }
        

        public Classe(string name)
        {
            this.name = name;
            Init();
        }

        private void Init()
        {
            switch (name.ToLower())
            {
                case "iop":
                    description = "Les Iops sont des chevaliers courageux sachant faire parler les armes. S'ils savaient ce qu'est un dicton, le leur serait : \" Agir, puis réfléchir \". Mais la grosseur de leur cerveau a beau être inversement proportionnelle à celle de leur épée, les Iops n'en restent pas moins des protecteurs appréciés de leurs alliés. Parce qu'ils le valent bien...";
                    break;
                case "xelor":
                    description = "Les Xélors se jouent du temps. Manipuler le tic-tac, telle est leur tactique ! Passionnés de mécanismes horlogers en tout genre, ils refusent de laisser filer la moindre seconde ou le moindre ennemi ! Si vous les voyez manipuler leurs aiguilles : fuyez ! Car c'est que votre heure a sonné...";
                    break;
                case "pandawa":
                    description = "Maîtres dans l'art du poing, les Pandawas sont également très habiles dans la discipline du lever de coude. Et à défaut de chopine, ce sont leurs ennemis qu'ils envoient valser dans les airs ! Souvenez-vous-en la prochaine fois que l'un d'eux vous proposera de vous \" payer un coup \"...";
                    break;
                case "feca":
                    description = "Les Fécas sont des protecteurs-nés. N'espérez pas vous emparer de ce qui leur a été confié, il faudra d'abord leur passer sur le corps et encore repasser ! Jusqu'à leur dernier souffle, ils veillent sans jamais lâcher. Ne vous en prenez pas non plus au premier Bouftou venu ! Même s'ils ne sont plus bergers, ils feront toujours barrage entre une créature sans défense et un agresseur malintentionné.";
                    break;
                case "osamodas":
                    description = "Le grondement d'un troupeau de Minotorors au galop ne les impressionne pas. Le cri perçant des Kwaks ne les agace aucunement, pas plus que le hurlement des Mulous ne les fait frémir. Leur empathie pour les créatures de la nature est si forte qu'eux-mêmes sont dotés d'un côté animal qui fait tout leur charme, mais aussi toute leur dangerosité.";
                    break;
                case "enutrof":
                    description = "Ils ne résistent ni à leur teint hâlé, ni à leur parfum chaleureux et encore moins à leurs courbes parfaites : les kamas, les Enutrofs en sont complètement gagas ! Pourvus d'une avarice à toute épreuve, ils sont capables de remuer ciel et terre avec leur pelle quand ils sont sur la piste d'un trésor. Ce qui en fait des alliés fort utiles et aide à oublier leur mauvais caractère et leur hygiène douteuse...";
                    break;
                case "sram":
                    description = "Ils ont beau se cacher derrière un masque, tout le monde connaît leur vrai visage : celui de la sournoiserie ! Les Srams n'ont pas leur pareil pour délester les aventuriers d'une bourse un peu trop remplie ou pour se débarrasser d'un ennemi trop encombrant lui aussi. En un mot, mieux vaut éviter de faire un tour du côté de chez Sram...";
                    break;
                case "ecaflip":
                    description = "Joueurs invétérés, les Ecaflips n'hésitent pas à mettre leur vie en danger pour l'amour du risque. Et contrairement aux idées reçues, il leur arrive de ne pas retomber sur leurs pattes... Peu importe : l'adrénaline que le jeu leur procure est bien trop forte ! Alors, prêt à mater du matou ?";
                    break;
                case "eniripsa":
                    description = "Depuis toujours, les Eniripsas sont réputés pour être d'inestimables soigneurs. Vous pouvez les croire sur parole : il leur suffit d'un mot pour vous guérir de tous les maux ! Quant à leurs ennemis, rassurez-vous, ils trouvent toujours un moyen de leur faire avaler la pilule...";
                    break;
                case "cra":
                    description = "\" Fierté et précision \", telle pourrait être la devise des Crâs. Spécialistes de l'attaque à distance, ces archers hors pair sont des alliés précieux qui ont plus d'une corde à leur arc pour tenir l'ennemi éloigné. Leur petit péché mignon : décocher leurs flèches dans les fessiers rebondis...";
                    break;
                case "sadida":
                    description = "S'ils se font surnommer \" Le Peuple des Arbres \", c'est en réalité toutes les créatures végétales que les Sadidas vénèrent. Et lorsqu'ils ne déclament pas leur amour aux plantes, ils jouent avec des poupées, de guerre ou de soin, qu'ils ont eux-mêmes confectionnées : un moyen comme un autre de s'accrocher aux branches en cas de danger.";
                    break;
                case "sacrieur":
                    description = "Les Sacrieurs ne craignent pas les blessures. Au contraire : ils tirent leur puissance des coups qu'on leur inflige ! Adeptes des longues soirées sang pour sang guerrières, ils font figure d'alliés précieux dans les mêlées franches. En un mot : pour l'adversaire, le disciple de Sacrieur est une véritable plaie !";
                    break;
                case "roublard":
                    description = "Tant champions que félons, les Roublards associent l'intelligence à la fourberie. Devenus maîtres dans l'art du bricolage, ils usent et abusent d'outils et gadgets pour mener à bien leurs plans. Au coeur de toute leur malice, une seule valeur trouve grâce à leurs yeux : le sens de la famille.";
                    break;
                case "zobal":
                    description = "Les Zobals sont les gardiens de masques aux pouvoirs étranges. Tantôt téméraires, tantôt couards, tantôt fous : ces aventuriers aux origines mystérieuses changent de visage comme de chemise. Leurs motivations sont assez obscures, mais souvent teintées d'un profond désir de vengeance...";
                    break;
                case "steamer":
                    description = "Patients et prudents, les Steamers attendent le meilleur moment pour agir... Au travers des siècles, ils ne cessent de s'améliorer, tant au niveau intellectuel que physique. Autrefois athées et belliqueux, ils sont désormais les ambassadeurs d'un peuple qui prône la paix. Leur mission : trouver des mines de Stasili et ainsi préparer le retour des leurs...";
                    break;
                case "eliotrope":
                    description = "Apparus par accident, les Eliotropes sont des reflets de leur créateur, le Roi-Dieu. Ils se déplacent à la vitesse de l'éclair, disparaissant en un clin d'œil pour réapparaître plus loin. Tout comme les Eliatropes, ils connaissent les secrets du Wakfu.";
                    break;
                case "huppermage":
                    description = "Maîtres des runes élémentaires, les Huppermages combinent les éléments Eau, Feu, Air et Terre pour créer des sorts d'une puissance à couper le souffle. Mus par leur soif de connaissance et l'importance de leur mission, ils étudient inlassablement les moyens de rétablir l'équilibre de la Balance Krosmique, garante de la stabilité du Monde des Douze.";
                    break;
                default:
                    description = "Pas encore disponible";
                    break;
            }
        }









    }
}