using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fputil_raise_except
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil12raise_exceptEi")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::raise_except(int)")]
	public unsafe static int Invoke([MangledName("excepts")][NativeType("int")] int Excepts)
	{
		short num = 0;
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		Llvm_lifetime_start_p0.Invoke(2L, &num);
		num = Internal_get_status_value_for_except.Invoke(Excepts);
		Llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb);
		unchecked
		{
			*(sbyte*)(&anon_izyfb) = -86;
			if (((ushort)num & 1) != 0)
			{
				Lambda_Invoke_g85ena.Invoke(&anon_izyfb, 1);
			}
			if (((ushort)num & 4) != 0)
			{
				Lambda_Invoke_g85ena.Invoke(&anon_izyfb, 4);
			}
			if (((ushort)num & 8) != 0)
			{
				Lambda_Invoke_g85ena.Invoke(&anon_izyfb, 8);
			}
			if (((ushort)num & 0x10) != 0)
			{
				Lambda_Invoke_g85ena.Invoke(&anon_izyfb, 16);
			}
			if (((ushort)num & 0x20) != 0)
			{
				Lambda_Invoke_g85ena.Invoke(&anon_izyfb, 32);
			}
			Llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb);
			Llvm_lifetime_end_p0.Invoke(2L, &num);
			return 0;
		}
	}
}
