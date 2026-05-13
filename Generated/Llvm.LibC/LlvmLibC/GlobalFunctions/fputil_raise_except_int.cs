using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil12raise_exceptEi")]
[DemangledName("__llvm_libc_20_1_2_::fputil::raise_except(int)")]
internal static partial class fputil_raise_except_int
{
	public unsafe static int Invoke(int excepts)
	{
		short num = 0;
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		llvm_lifetime_start_p0.Invoke(2L, &num);
		num = fputil_internal_get_status_value_for_except_int.Invoke(excepts);
		llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb8);
		unchecked
		{
			*(sbyte*)(&anon_izyfb8) = -86;
			if (((ushort)num & 1) != 0)
			{
				fputil_raise_except_int_lambda_unsigned_short_operator_unsigned_short_const.Invoke(&anon_izyfb8, 1);
			}
			if (((ushort)num & 4) != 0)
			{
				fputil_raise_except_int_lambda_unsigned_short_operator_unsigned_short_const.Invoke(&anon_izyfb8, 4);
			}
			if (((ushort)num & 8) != 0)
			{
				fputil_raise_except_int_lambda_unsigned_short_operator_unsigned_short_const.Invoke(&anon_izyfb8, 8);
			}
			if (((ushort)num & 0x10) != 0)
			{
				fputil_raise_except_int_lambda_unsigned_short_operator_unsigned_short_const.Invoke(&anon_izyfb8, 16);
			}
			if (((ushort)num & 0x20) != 0)
			{
				fputil_raise_except_int_lambda_unsigned_short_operator_unsigned_short_const.Invoke(&anon_izyfb8, 32);
			}
			llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb8);
			llvm_lifetime_end_p0.Invoke(2L, &num);
			return 0;
		}
	}
}
