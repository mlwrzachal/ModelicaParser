<Architecture>
  <Name>Architecture 1</Name>
  <FlowTypes>
    <FlowType Name='Fluid' Colour='-16776961' />
    <FlowType Name='Heat' Colour='-65536' />
    <FlowType Name='Mechanical' Colour='-23296' />
    <FlowType Name='Electrical' Colour='-16744448' />
  </FlowTypes>
  <Components>
    <Component>
      <Name>HX</Name>
      <FMU_path>test1.files\FMUs\HX.fmu</FMU_path>
      <Location X='207.950363' Y='346.922668' />
      <Size Width='60' Height='60' />
      <Colour>-16711681</Colour>
      <Parent>ECS</Parent>
      <Children />
      <Parameters>
        <Parameter Name='effi' Value='0.9' />
        <Parameter Name='Pfact' Value='1' />
        <Parameter Name='Tfact' Value='60' />
        <Parameter Name='PAX' Value='150' />
        <Parameter Name='Cp_hotfluid' Value='1005' />
        <Parameter Name='Cp_coldfluid' Value='1003' />
      </Parameters>
      <Icon>test1.files\icons\HX.png</Icon>
      <PortList>
        <Port>
          <Name>Port 1</Name>
          <Direction>output</Direction>
          <Type>Heat</Type>
          <Location>bottom</Location>
          <Variables>
            <Variable Name='P' Value='0' />
            <Variable Name='T' Value='0' />
          </Variables>
        </Port>
        <Port>
          <Name>Port 2</Name>
          <Direction>output</Direction>
          <Type>Fluid</Type>
          <Location>right</Location>
          <Variables>
            <Variable Name='P' Value='0' />
            <Variable Name='T' Value='0' />
          </Variables>
        </Port>
        <Port>
          <Name>Port 3</Name>
          <Direction>input</Direction>
          <Type>Fluid</Type>
          <Location>left</Location>
          <Variables>
            <Variable Name='P' Value='0' />
            <Variable Name='T' Value='0' />
          </Variables>
        </Port>
        <Port>
          <Name>Port 4</Name>
          <Direction>input</Direction>
          <Type>Heat</Type>
          <Location>top</Location>
          <Variables>
            <Variable Name='P' Value='0' />
            <Variable Name='T' Value='0' />
          </Variables>
        </Port>
      </PortList>
    </Component>
    <Component>
      <Name>Engine</Name>
      <FMU_path>none</FMU_path>
      <Location X='61.3167877' Y='427.724121' />
      <Size Width='60' Height='60' />
      <Colour>-16711681</Colour>
      <Parent />
      <Children />
      <Parameters />
      <Icon>test1.files\icons\Engine.png</Icon>
      <PortList>
        <Port>
          <Name>Port 1</Name>
          <Direction>output</Direction>
          <Type>Fluid</Type>
          <Location>top</Location>
          <Variables />
        </Port>
      </PortList>
    </Component>
    <Component>
      <Name>Flow Control Valve</Name>
      <FMU_path>test1.files\FMUs\FlowControlValve.fmu</FMU_path>
      <Location X='343.91098' Y='328.3905' />
      <Size Width='60' Height='60' />
      <Colour>-16711681</Colour>
      <Parent>ECS</Parent>
      <Children />
      <Parameters>
        <Parameter Name='BleedTemp' Value='463' />
        <Parameter Name='BleedPress' Value='3.03' />
      </Parameters>
      <Icon>test1.files\icons\FlowControlValve.png</Icon>
      <PortList>
        <Port>
          <Name>Port 1</Name>
          <Direction>output</Direction>
          <Type>Fluid</Type>
          <Location>top</Location>
          <Variables>
            <Variable Name='P' Value='0' />
            <Variable Name='T' Value='0' />
          </Variables>
        </Port>
        <Port>
          <Name>Port 2</Name>
          <Direction>input</Direction>
          <Type>Fluid</Type>
          <Location>bottom</Location>
          <Variables />
        </Port>
      </PortList>
    </Component>
    <Component>
      <Name>Cabin</Name>
      <FMU_path>none</FMU_path>
      <Location X='378.70813' Y='34.0619774' />
      <Size Width='60' Height='60' />
      <Colour>-16711681</Colour>
      <Parent>Air Quality System</Parent>
      <Children />
      <Parameters />
      <Icon>test1.files\icons\Cabin.png</Icon>
      <PortList>
        <Port>
          <Name>Port 1</Name>
          <Direction>input</Direction>
          <Type>Fluid</Type>
          <Location>bottom</Location>
          <Variables />
        </Port>
        <Port>
          <Name>Port 2</Name>
          <Direction>output</Direction>
          <Type>Fluid</Type>
          <Location>bottom</Location>
          <Variables />
        </Port>
      </PortList>
    </Component>
    <Component>
      <Name>Mixing Unit</Name>
      <FMU_path>none</FMU_path>
      <Location X='474.927216' Y='237.638641' />
      <Size Width='60' Height='60' />
      <Colour>-16711681</Colour>
      <Parent>ECS</Parent>
      <Children />
      <Parameters />
      <Icon>test1.files\icons\MixingUnit.png</Icon>
      <PortList>
        <Port>
          <Name>Port 1</Name>
          <Direction>input</Direction>
          <Type>Fluid</Type>
          <Location>bottom</Location>
          <Variables />
        </Port>
        <Port>
          <Name>Port 2</Name>
          <Direction>output</Direction>
          <Type>Fluid</Type>
          <Location>top</Location>
          <Variables />
        </Port>
        <Port>
          <Name>Port 3</Name>
          <Direction>input</Direction>
          <Type>Fluid</Type>
          <Location>top</Location>
          <Variables />
        </Port>
      </PortList>
    </Component>
    <Component>
      <Name>ECS</Name>
      <FMU_path>none</FMU_path>
      <Location X='201.950363' Y='222.5475' />
      <Size Width='60' Height='60' />
      <Colour>-16711681</Colour>
      <Parent>Air Quality System</Parent>
      <Children>
        <Child>HX</Child>
        <Child>Flow Control Valve</Child>
        <Child>Mixing Unit</Child>
      </Children>
      <Parameters />
      <Icon>none</Icon>
      <PortList />
    </Component>
    <Component>
      <Name>Air Quality System</Name>
      <FMU_path>none</FMU_path>
      <Location X='191.950363' Y='18.9708328' />
      <Size Width='60' Height='60' />
      <Colour>-16711681</Colour>
      <Parent />
      <Children>
        <Child>Cabin</Child>
        <Child>ECS</Child>
      </Children>
      <Parameters />
      <Icon>none</Icon>
      <PortList />
    </Component>
  </Components>
  <Functions>
    <Function>
      <Name>Function 1</Name>
      <Description />
      <Parent>Function 4</Parent>
      <Children />
      <Location X='111' Y='435.1823' />
      <Size Width='60' Height='80' />
    </Function>
    <Function>
      <Name>Function 2</Name>
      <Description />
      <Parent>Function 4</Parent>
      <Children />
      <Location X='235' Y='330.1823' />
      <Size Width='60' Height='80' />
    </Function>
    <Function>
      <Name>Function 3</Name>
      <Description />
      <Parent>Function 4</Parent>
      <Children />
      <Location X='352' Y='216.1823' />
      <Size Width='60' Height='80' />
    </Function>
    <Function>
      <Name>Function 4</Name>
      <Description />
      <Parent>Function 5</Parent>
      <Children>
        <Child>Function 1</Child>
        <Child>Function 2</Child>
        <Child>Function 3</Child>
      </Children>
      <Location X='111' Y='201.0912' />
      <Size Width='60' Height='80' />
    </Function>
    <Function>
      <Name>Function 5</Name>
      <Description />
      <Parent />
      <Children>
        <Child>Function 4</Child>
        <Child>Function 6</Child>
      </Children>
      <Location X='107' Y='41.90886' />
      <Size Width='60' Height='80' />
    </Function>
    <Function>
      <Name>Function 6</Name>
      <Description />
      <Parent>Function 5</Parent>
      <Children />
      <Location X='278' Y='57' />
      <Size Width='60' Height='80' />
    </Function>
    <Function>
      <Name>Function 7</Name>
      <Description />
      <Parent />
      <Children />
      <Location X='36' Y='481' />
      <Size Width='60' Height='80' />
    </Function>
  </Functions>
  <FunctionalAssociations />
  <Requirements />
  <FlowLinks>
    <Link From='HX:Port 2' To='Flow Control Valve:Port 2' Label='Fluid' />
    <Link From='Engine:Port 1' To='HX:Port 3' Label='Fluid' />
    <Link From='Flow Control Valve:Port 1' To='Mixing Unit:Port 1' Label='Fluid' />
    <Link From='Cabin:Port 2' To='Mixing Unit:Port 3' Label='Fluid' />
    <Link From='Mixing Unit:Port 2' To='Cabin:Port 1' Label='Fluid' />
  </FlowLinks>
  <FunctionalImplementations>
    <Association Function='Function 1' Port='HX:Port 1' />
    <Association Function='Function 1' Port='HX:Port 2' />
    <Association Function='Function 1' Port='HX:Port 3' />
    <Association Function='Function 1' Port='HX:Port 4' />
    <Association Function='Function 2' Port='Flow Control Valve:Port 1' />
    <Association Function='Function 2' Port='Flow Control Valve:Port 2' />
    <Association Function='Function 3' Port='Mixing Unit:Port 1' />
    <Association Function='Function 3' Port='Mixing Unit:Port 2' />
    <Association Function='Function 3' Port='Mixing Unit:Port 3' />
    <Association Function='Function 6' Port='Cabin:Port 1' />
    <Association Function='Function 6' Port='Cabin:Port 2' />
    <Association Function='Function 7' Port='Engine:Port 1' />
  </FunctionalImplementations>
</Architecture>