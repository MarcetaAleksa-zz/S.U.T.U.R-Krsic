
/*FROM first_table join_type second_table [ON (join_condition)]*/
declare @ma int
Set @ma = 4
declare @mj int
set @mj = (SELECT mjeseci.dani_u_mjesecu from mjeseci where @ma = mjeces_id)
declare @ird int
declare @id VarChar(50)
set @id = 'Aleksandar'

IF @mj=31
      SET @ird = 22 ;
ELSE IF @mj=30
      SET @ird = 19 ;
Else
	 SET @ird = 17;
SELECT @ird*pz.radni_sati_po_danu*pz.satnica as plata, * 
from  dbo.spoj_tabela as sp left join pozicija as pz
on (sp.pozicija_id = pz.pozicija_id)
where korisnicki_id = 'Aleksandar'


