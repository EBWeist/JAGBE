﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using static JAGBETests.RomTests.Helpers;

namespace JAGBETests.RomTests.mooneye
{
    [TestClass]
    [TestCategory("mooneye-gb_hwtests/acceptance")]
    public class AcceptanceTests
    {
        internal const string BasePath = "mooneye-gb_hwtests/acceptance/";

        [TestMethod]
        public void Add_sp_e_timing() => TestDisplayOut(BasePath + "add_sp_e_timing.gb", "", false);

        [TestMethod]
        public void Boot_hwio_dmgABCXmgb() => TestDisplayOut(BasePath + "boot_hwio-dmgABCXmgb.gb", "", false);

        [TestMethod]
        public void Boot_regs_dmgABCX() =>
            TestDisplayOut(BasePath + "boot_regs-dmgABCX.gb", "2pe1gNp6ILzHC1A8Ds4tTn7GKwImh18zL3UWsVZkCpg=", true);

        [TestMethod]
        public void Call_cc_timing() => TestDisplayOut(BasePath + "call_cc_timing.gb", "", false);

        [TestMethod]
        public void Call_cc_timing2() =>
            TestDisplayOut(BasePath + "call_cc_timing2.gb", "", false, "wqZ9ZsSSV+6kxTzO2wijXA5oEvjFrcD/We7RuPx9I9A=");

        [TestMethod]
        public void Call_timing() => TestDisplayOut(BasePath + "call_timing.gb", "", false);

        [TestMethod]
        public void Call_timing2() =>
            TestDisplayOut(BasePath + "call_timing2.gb", "", false, "UH90vAIjthK2Ql6NvhcrZ328v1LPr3WaTV3+T9CmNhU=");

        [TestMethod]
        public void DI_timing_GS() => TestDisplayOut(BasePath + "di_timing-GS.gb",
                "ct/pSMvekPxIlT/NLHziuq1NDmhtjOC6zt2GF3aDBrs=", true, "Z/A8HucoeyOxrdLafSqS+mpn5CkHhdA4FHDukzLRiX8=");

        [TestMethod]
        public void Div_timing() => TestDisplayOut(BasePath + "div_timing.gb", "gLcCnRta6x+9hIQm+320dn8ErOqS9fFYGCKsAuZXQ2E=", true);

        [TestMethod]
        public void EI_timing() => TestDisplayOut(BasePath + "ei_timing.gb", "jPm4UvL49A9TOhdjVuUCOctyOBxcpInzC1frlVtyq1s=", true);

        [TestMethod]
        public void Halt_ime0_ei() => TestDisplayOut(BasePath + "halt_ime0_ei.gb",
                "ct/pSMvekPxIlT/NLHziuq1NDmhtjOC6zt2GF3aDBrs=", true, "AnWWPp+xnxUr2GjoSXOUdV7oZ5EPH4savUqemGjbhOY=");

        [TestMethod]
        public void Halt_ime0_nointr_timing() => TestDisplayOut(BasePath + "halt_ime0_nointr_timing.gb",
            "fhCgcQQgNlaCD5mBqW/1p7BzL7WFePpyl9XBsQ2IgDo=", false, "dNfQNna3+uXVgXqbO75q7efD6RF4zyqKXx27+4hexwI=");

        [TestMethod]
        public void Halt_ime1_timing() => TestDisplayOut(BasePath + "halt_ime1_timing.gb",
                "r5y/HXCLUcM4l2QrFNIScGp9L44Xa5Xdp2odZOyW3Js=", true, "cy7J8YaX4Ko0nepL7j8zgVcqHiIbG31/wEDdIgF28RQ=");

        [TestMethod]
        public void Halt_ime1_timing2_GS()
        {
            string[] failShas = { "Z/A8HucoeyOxrdLafSqS+mpn5CkHhdA4FHDukzLRiX8=", "nMD8ePZ4OAlzWMZZirdn6emz8UF4gkJaWStjbRZ9gq8=" };
            TestDisplayOut(BasePath + "halt_ime1_timing2-GS.gb", "mYRy+tkF2McRZrOD90zONWZv4diwUfG3cuPjvOEHZJM=", false, failShas);
        }

        [TestMethod]
        public void IF_IE_registers() =>
            TestDisplayOut(BasePath + "if_ie_registers.gb", "cMXEWWiLEgUdvTelKty/59AYf5GPI71lp5DpGS45n6c=", true);

        [TestMethod]
        public void Intr_timing() =>
            TestDisplayOut(BasePath + "intr_timing.gb", "", false, "qwFopvffHxTuf5opCeRPLlBmiyuLa2lofunGI5fDWaY=");

        [TestMethod]
        public void JP_cc_timing() => TestDisplayOut(BasePath + "jp_cc_timing.gb", "", false);

        [TestMethod]
        public void JP_timing() => TestDisplayOut(BasePath + "jp_timing.gb", "", false);

        [TestMethod]
        public void LD_hl_sp_e_timing() => TestDisplayOut(BasePath + "ld_hl_sp_e_timing.gb", "", false);

        [TestMethod]
        public void Oam_dma_restart() =>
            TestDisplayOut(BasePath + "oam_dma_restart.gb", "j9oxRWGIXPDL+nSTCyJtroBt2PwJNvRFtTD1t03y/8A=", true);

        [TestMethod]
        public void Oam_dma_start() =>
            TestDisplayOut(BasePath + "oam_dma_start.gb", "", false, "tiJkAdxFIo8/oW/wNGruvLjp4DlxuSBdvk72WjMNmHc=");

        [TestMethod]
        public void Oam_dma_timing() =>
            TestDisplayOut(BasePath + "oam_dma_timing.gb", "j9oxRWGIXPDL+nSTCyJtroBt2PwJNvRFtTD1t03y/8A=", true);

        [TestMethod]
        public void Pop_timing() => TestDisplayOut(BasePath + "pop_timing.gb", "yXzxDxECgU1W/KW+HBl9/2LLopxEkMGJ83lOv6siIVc=", true);

        [TestMethod]
        public void Push_timing() =>
            TestDisplayOut(BasePath + "push_timing.gb", "", false, "VF/tCFq84MMOtrYh5u/EsfVT2RRHM+On7WmZ7bAgQ84=");

        [TestMethod]
        public void Rapid_DI_EI() => TestDisplayOut(BasePath + "rapid_di_ei.gb", "GUYCaGx8WO8jS7qPZdfAZplqRj1HY04nSuhJ+Lahdnw=", true);

        [TestMethod]
        public void Ret_cc_timing() => TestDisplayOut(BasePath + "ret_cc_timing.gb", "", false);

        [TestMethod]
        public void Ret_timing() => TestDisplayOut(BasePath + "ret_timing.gb", "", false);

        [TestMethod]
        public void Reti_intr_timing() =>
            TestDisplayOut(BasePath + "reti_intr_timing.gb", "Rue6zf+aapVRSCfsX7QHbX/V/RiDO1BrLV2bC3uqN2A=", true);

        [TestMethod]
        public void Reti_timing() => TestDisplayOut(BasePath + "reti_timing.gb", "", false);

        [TestMethod]
        public void Rst_timing() =>
            TestDisplayOut(BasePath + "rst_timing.gb", "", false, "7a3HVqa/UVqs4QO9PZFo3juGa9eIBk5ocJtQGiixA3Y=");
    }
}
