using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class fputil_raise_except
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil12raise_exceptEi")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::raise_except(int)")]
	public unsafe static int Invoke([NativeType("int")] int excepts)
	{
		short num = 0;
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		llvm_lifetime_start_p0.Invoke(2L, &num);
		num = internal_get_status_value_for_except.Invoke(excepts);
		llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb8);
		unchecked
		{
			*(sbyte*)(&anon_izyfb8) = -86;
			if (((ushort)num & 1) != 0)
			{
				lambda_Invoke_g85ena.Invoke(&anon_izyfb8, 1);
			}
			if (((ushort)num & 4) != 0)
			{
				lambda_Invoke_g85ena.Invoke(&anon_izyfb8, 4);
			}
			if (((ushort)num & 8) != 0)
			{
				lambda_Invoke_g85ena.Invoke(&anon_izyfb8, 8);
			}
			if (((ushort)num & 0x10) != 0)
			{
				lambda_Invoke_g85ena.Invoke(&anon_izyfb8, 16);
			}
			if (((ushort)num & 0x20) != 0)
			{
				lambda_Invoke_g85ena.Invoke(&anon_izyfb8, 32);
			}
			llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb8);
			llvm_lifetime_end_p0.Invoke(2L, &num);
			return 0;
		}
	}
}
