using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Enumerations;
using LlvmLibC.GlobalVariables;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_8internal12eisel_lemireIfEENS_3cpp8optionalINS0_13ExpandedFloatIT_EEEES6_NS0_14RoundDirectionE")]
[DemangledName("__llvm_libc_20_1_2_::cpp::optional<__llvm_libc_20_1_2_::internal::ExpandedFloat<float>> __llvm_libc_20_1_2_::internal::eisel_lemire<float>(__llvm_libc_20_1_2_::internal::ExpandedFloat<float>, __llvm_libc_20_1_2_::internal::RoundDirection)")]
internal static partial class cpp_optional_internal_ExpandedFloat_float_internal_eisel_lemire_float_internal_ExpandedFloat_float_internal_RoundDirection
{
	public unsafe static Struct_8myw6y Invoke([MangledName("init_num.coerce")] long init_num, RoundDirection_b3pcwy round)
	{
		cpp_optional_6hseum cpp_optional_6hseum2 = default(cpp_optional_6hseum);
		internal_ExpandedFloat_i7t5up internal_ExpandedFloat_i7t5up2 = default(internal_ExpandedFloat_i7t5up);
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		void* ptr = null;
		Int128 @int = default(Int128);
		Int128 int2 = default(Int128);
		long num5 = 0L;
		Int128 int3 = default(Int128);
		Int128 int4 = default(Int128);
		int num6 = 0;
		int num7 = 0;
		internal_ExpandedFloat_i7t5up internal_ExpandedFloat_i7t5up3 = default(internal_ExpandedFloat_i7t5up);
		Struct_8myw6y result = default(Struct_8myw6y);
		unchecked
		{
			*(long*)(&internal_ExpandedFloat_i7t5up2) = init_num;
			llvm_lifetime_start_p0.Invoke(4L, &num);
			num = internal_ExpandedFloat_i7t5up2.mantissa;
			llvm_lifetime_start_p0.Invoke(4L, &num2);
			num2 = internal_ExpandedFloat_i7t5up2.exponent;
			if (num2 < -348 || num2 > 347)
			{
				cpp_optional_internal_ExpandedFloat_float_optional_cpp_nullopt_t.Invoke(&cpp_optional_6hseum2);
				goto IL_04f9;
			}
			llvm_lifetime_start_p0.Invoke(4L, &num3);
			num3 = cpp_enable_if_cpp_is_unsigned_v_unsigned_int_int_type_cpp_countl_zero_unsigned_int_unsigned_int.Invoke(num);
			num <<= num3;
			llvm_lifetime_start_p0.Invoke(4L, &num4);
			num4 = checked(internal_exp10_to_exp2_int.Invoke(num2) + 32 + 127) - num3;
			llvm_lifetime_start_p0.Invoke(8L, &ptr);
			long num8 = checked(num2 - -348);
			ptr = (byte*)internal_DETAILED_POWERS_OF_TEN.Pointer + (nint)num8 * sizeof(InlineArray2_Int64);
			llvm_lifetime_start_p0.Invoke(16L, &@int);
			@int = NumericHelper.Multiply((Int128)(UInt128)(uint)num, (Int128)(UInt128)((ulong*)ptr)[1]);
			llvm_lifetime_start_p0.Invoke(16L, &int2);
			int2 = -6148914691236517206L;
			llvm_lifetime_start_p0.Invoke(8L, &num5);
			num5 = 63L;
			if ((internal_high64_unsigned_int128_const.Invoke(&@int) & 0x3FL) == 63L && (ulong)(internal_low64_unsigned_int128_const.Invoke(&@int) + (uint)num) < (ulong)(uint)num)
			{
				llvm_lifetime_start_p0.Invoke(16L, &int3);
				int3 = NumericHelper.Multiply((Int128)(UInt128)(uint)num, (Int128)(UInt128)(*(ulong*)ptr));
				llvm_lifetime_start_p0.Invoke(16L, &int4);
				int4 = NumericHelper.Add(@int, (Int128)(UInt128)(ulong)internal_high64_unsigned_int128_const.Invoke(&int3));
				int num9;
				if ((internal_high64_unsigned_int128_const.Invoke(&int4) & 0x3FL) == 63L && internal_low64_unsigned_int128_const.Invoke(&int4) + 1L == 0L && (ulong)(internal_low64_unsigned_int128_const.Invoke(&int3) + (uint)num) < (ulong)(uint)num)
				{
					cpp_optional_internal_ExpandedFloat_float_optional_cpp_nullopt_t.Invoke(&cpp_optional_6hseum2);
					num9 = 1;
				}
				else
				{
					int2 = int4;
					num9 = 0;
				}
				llvm_lifetime_end_p0.Invoke(16L, &int4);
				llvm_lifetime_end_p0.Invoke(16L, &int3);
				switch (num9)
				{
				case 0:
					break;
				default:
					goto IL_0497;
				}
			}
			else
			{
				int2 = @int;
			}
			llvm_lifetime_start_p0.Invoke(4L, &num6);
			num6 = (int)(internal_high64_unsigned_int128_const.Invoke(&int2) >>> 31);
			llvm_lifetime_start_p0.Invoke(4L, &num7);
			num7 = (int)(internal_high64_unsigned_int128_const.Invoke(&int2) >>> (int)(uint)(num6 + 32 - 26));
			num4 -= 1 ^ num6;
			if (round == RoundDirection_b3pcwy.Nearest)
			{
				if (internal_low64_unsigned_int128_const.Invoke(&int2) == 0L && (internal_high64_unsigned_int128_const.Invoke(&int2) & 0x3FL) == 0L && (num7 & 3) == 1)
				{
					cpp_optional_internal_ExpandedFloat_float_optional_cpp_nullopt_t.Invoke(&cpp_optional_6hseum2);
					goto IL_0475;
				}
				num7 += num7 & 1;
			}
			else if (round == RoundDirection_b3pcwy.Up && ((ulong)internal_low64_unsigned_int128_const.Invoke(&int2) > 0uL || (ulong)(internal_high64_unsigned_int128_const.Invoke(&int2) & 0x3FL) > 0uL))
			{
				num7 += 2;
			}
			num7 >>>= 1;
			if ((uint)num7 >> 24 != 0)
			{
				num7 >>>= 1;
				num4 = checked(num4 + 1);
			}
			if ((uint)(num4 - 1) >= 254u)
			{
				cpp_optional_internal_ExpandedFloat_float_optional_cpp_nullopt_t.Invoke(&cpp_optional_6hseum2);
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(8L, &internal_ExpandedFloat_i7t5up3);
				*(int*)(&internal_ExpandedFloat_i7t5up3) = -1431655766;
				((int*)(&internal_ExpandedFloat_i7t5up3))[1] = -1431655766;
				internal_ExpandedFloat_i7t5up3.mantissa = num7;
				internal_ExpandedFloat_i7t5up3.exponent = num4;
				cpp_optional_internal_ExpandedFloat_float_optional_internal_ExpandedFloat_float.Invoke(&cpp_optional_6hseum2, &internal_ExpandedFloat_i7t5up3);
				llvm_lifetime_end_p0.Invoke(8L, &internal_ExpandedFloat_i7t5up3);
			}
			goto IL_0475;
		}
		IL_0497:
		llvm_lifetime_end_p0.Invoke(8L, &num5);
		llvm_lifetime_end_p0.Invoke(16L, &int2);
		llvm_lifetime_end_p0.Invoke(16L, &@int);
		llvm_lifetime_end_p0.Invoke(8L, &ptr);
		llvm_lifetime_end_p0.Invoke(4L, &num4);
		llvm_lifetime_end_p0.Invoke(4L, &num3);
		goto IL_04f9;
		IL_0475:
		llvm_lifetime_end_p0.Invoke(4L, &num7);
		llvm_lifetime_end_p0.Invoke(4L, &num6);
		goto IL_0497;
		IL_04f9:
		llvm_lifetime_end_p0.Invoke(4L, &num2);
		llvm_lifetime_end_p0.Invoke(4L, &num);
		llvm_memcpy_p0_p0_i64.Invoke(&result, &cpp_optional_6hseum2.storage, 12L, isVolatile: false);
		return result;
	}
}
