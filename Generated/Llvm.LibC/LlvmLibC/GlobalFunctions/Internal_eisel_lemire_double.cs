using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Enumerations;
using LlvmLibC.GlobalVariables;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Internal_eisel_lemire_double
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal12eisel_lemireIdEENS_3cpp8optionalINS0_13ExpandedFloatIT_EEEES6_NS0_14RoundDirectionE")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<__llvm_libc_20_1_2_::internal::ExpandedFloat<double>> __llvm_libc_20_1_2_::internal::eisel_lemire<double>(__llvm_libc_20_1_2_::internal::ExpandedFloat<double>, __llvm_libc_20_1_2_::internal::RoundDirection)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::optional<__llvm_libc_20_1_2_::internal::ExpandedFloat<double>>")]
	public unsafe static void Invoke([MangledName("agg.result")] Cpp_optional_9m4esb* Agg_result, [MangledName("init_num.coerce0")] long Init_num, [MangledName("init_num.coerce1")] RoundDirection_b3pcwy Round, [MangledName("round")] int Mantissa)
	{
		Internal_ExpandedFloat_k68bhv internal_ExpandedFloat_k68bhv = default(Internal_ExpandedFloat_k68bhv);
		long num = 0L;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		void* ptr = null;
		Int128 @int = default(Int128);
		Int128 int2 = default(Int128);
		long num5 = 0L;
		Int128 int3 = default(Int128);
		Int128 int4 = default(Int128);
		long num6 = 0L;
		long num7 = 0L;
		Internal_ExpandedFloat_k68bhv internal_ExpandedFloat_k68bhv2 = default(Internal_ExpandedFloat_k68bhv);
		unchecked
		{
			*(long*)(&internal_ExpandedFloat_k68bhv) = Init_num;
			((int*)(&internal_ExpandedFloat_k68bhv))[2] = (int)Round;
			Llvm_lifetime_start_p0.Invoke(8L, &num);
			num = internal_ExpandedFloat_k68bhv.Mantissa;
			Llvm_lifetime_start_p0.Invoke(4L, &num2);
			num2 = internal_ExpandedFloat_k68bhv.Exponent;
			if (num2 < -348 || num2 > 347)
			{
				Optional_internal_ExpandedFloat_double_Constructor_ws8gcn.Invoke(Agg_result);
				goto IL_0568;
			}
			Llvm_lifetime_start_p0.Invoke(4L, &num3);
			num3 = Cpp_countl_zero_unsigned_long.Invoke(num);
			num <<= (int)(uint)num3;
			Llvm_lifetime_start_p0.Invoke(4L, &num4);
			num4 = checked(Internal_exp10_to_exp2.Invoke(num2) + 64 + 1023) - num3;
			Llvm_lifetime_start_p0.Invoke(8L, &ptr);
			long num8 = checked(num2 - -348);
			ptr = (byte*)Internal_DETAILED_POWERS_OF_TEN.Pointer + (nint)num8 * sizeof(InlineArray2_Int64);
			Llvm_lifetime_start_p0.Invoke(16L, &@int);
			@int = NumericHelper.Multiply((Int128)(UInt128)(ulong)num, (Int128)(UInt128)((ulong*)ptr)[1]);
			Llvm_lifetime_start_p0.Invoke(16L, &int2);
			int2 = -6148914691236517206L;
			Llvm_lifetime_start_p0.Invoke(8L, &num5);
			num5 = 511L;
			if ((Internal_high64.Invoke(&@int) & 0x1FFL) == 511L && (ulong)(Internal_low64.Invoke(&@int) + num) < (ulong)num)
			{
				Llvm_lifetime_start_p0.Invoke(16L, &int3);
				int3 = NumericHelper.Multiply((Int128)(UInt128)(ulong)num, (Int128)(UInt128)(*(ulong*)ptr));
				Llvm_lifetime_start_p0.Invoke(16L, &int4);
				int4 = NumericHelper.Add(@int, (Int128)(UInt128)(ulong)Internal_high64.Invoke(&int3));
				int num9;
				if ((Internal_high64.Invoke(&int4) & 0x1FFL) == 511L && Internal_low64.Invoke(&int4) + 1L == 0L && (ulong)(Internal_low64.Invoke(&int3) + num) < (ulong)num)
				{
					Optional_internal_ExpandedFloat_double_Constructor_ws8gcn.Invoke(Agg_result);
					num9 = 1;
				}
				else
				{
					int2 = int4;
					num9 = 0;
				}
				Llvm_lifetime_end_p0.Invoke(16L, &int4);
				Llvm_lifetime_end_p0.Invoke(16L, &int3);
				switch (num9)
				{
				case 0:
					break;
				default:
					goto IL_0506;
				}
			}
			else
			{
				int2 = @int;
			}
			Llvm_lifetime_start_p0.Invoke(8L, &num6);
			num6 = Internal_high64.Invoke(&int2) >>> 63;
			Llvm_lifetime_start_p0.Invoke(8L, &num7);
			num7 = Internal_high64.Invoke(&int2) >>> (int)(num6 + 64L - 55L);
			num4 -= (int)(1L ^ num6);
			if (Mantissa == 2)
			{
				if (Internal_low64.Invoke(&int2) == 0L && (Internal_high64.Invoke(&int2) & 0x1FFL) == 0L && (num7 & 3L) == 1L)
				{
					Optional_internal_ExpandedFloat_double_Constructor_ws8gcn.Invoke(Agg_result);
					goto IL_04e4;
				}
				num7 += num7 & 1L;
			}
			else if (Mantissa == 0 && ((ulong)Internal_low64.Invoke(&int2) > 0uL || (ulong)(Internal_high64.Invoke(&int2) & 0x1FFL) > 0uL))
			{
				num7 += 2L;
			}
			num7 >>>= 1;
			if ((ulong)(num7 >>> 53) > 0uL)
			{
				num7 >>>= 1;
				num4 = checked(num4 + 1);
			}
			if ((uint)(num4 - 1) >= 2046u)
			{
				Optional_internal_ExpandedFloat_double_Constructor_ws8gcn.Invoke(Agg_result);
			}
			else
			{
				Llvm_lifetime_start_p0.Invoke(16L, &internal_ExpandedFloat_k68bhv2);
				*(long*)(&internal_ExpandedFloat_k68bhv2) = -6148914691236517206L;
				((int*)(&internal_ExpandedFloat_k68bhv2))[2] = -1431655766;
				sbyte* ptr2 = (sbyte*)(&internal_ExpandedFloat_k68bhv2) + 12;
				*ptr2 = -86;
				ptr2[1] = -86;
				ptr2[2] = -86;
				ptr2[3] = -86;
				internal_ExpandedFloat_k68bhv2.Mantissa = num7;
				internal_ExpandedFloat_k68bhv2.Exponent = num4;
				Optional_internal_ExpandedFloat_double_Constructor_w43rtw.Invoke(Agg_result, &internal_ExpandedFloat_k68bhv2);
				Llvm_lifetime_end_p0.Invoke(16L, &internal_ExpandedFloat_k68bhv2);
			}
			goto IL_04e4;
		}
		IL_0506:
		Llvm_lifetime_end_p0.Invoke(8L, &num5);
		Llvm_lifetime_end_p0.Invoke(16L, &int2);
		Llvm_lifetime_end_p0.Invoke(16L, &@int);
		Llvm_lifetime_end_p0.Invoke(8L, &ptr);
		Llvm_lifetime_end_p0.Invoke(4L, &num4);
		Llvm_lifetime_end_p0.Invoke(4L, &num3);
		goto IL_0568;
		IL_04e4:
		Llvm_lifetime_end_p0.Invoke(8L, &num7);
		Llvm_lifetime_end_p0.Invoke(8L, &num6);
		goto IL_0506;
		IL_0568:
		Llvm_lifetime_end_p0.Invoke(4L, &num2);
		Llvm_lifetime_end_p0.Invoke(8L, &num);
	}
}
