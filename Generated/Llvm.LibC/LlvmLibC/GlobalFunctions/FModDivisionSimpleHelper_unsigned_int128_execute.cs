using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FModDivisionSimpleHelper_unsigned_int128_execute
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil7generic24FModDivisionSimpleHelperIoE7executeEiioo")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::generic::FModDivisionSimpleHelper<unsigned __int128>::execute(int, int, unsigned __int128, unsigned __int128)")]
	public unsafe static Struct_fiz2nb Invoke([MangledName("exp_diff")] int Exp_diff, [MangledName("sides_zeroes_count")] int Sides_zeroes_count, [MangledName("m_x.coerce0")] long M_x, [MangledName("m_x.coerce1")] long M_y, [MangledName("m_y.coerce0")] long M_y_coerce0, [MangledName("m_y.coerce1")] long M_y_coerce1)
	{
		Int128 @int = default(Int128);
		Int128 int2 = default(Int128);
		unchecked
		{
			*(long*)(&@int) = M_x;
			((long*)(&@int))[1] = M_y;
			Int128 int3 = @int;
			*(long*)(&int2) = M_y_coerce0;
			((long*)(&int2))[1] = M_y_coerce1;
			Int128 int4 = int2;
			int num = Exp_diff;
			Int128 x = int3;
			Int128 y = int4;
			while (num > Sides_zeroes_count)
			{
				num = checked(num - Sides_zeroes_count);
				x = NumericHelper.RemainderUnsigned(NumericHelper.ShiftLeft(x, (Int128)(UInt128)(uint)Sides_zeroes_count), y);
			}
			Int128 int5 = NumericHelper.RemainderUnsigned(NumericHelper.ShiftLeft(x, (Int128)(UInt128)(uint)num), y);
			return *(Struct_fiz2nb*)(&int5);
		}
	}
}
