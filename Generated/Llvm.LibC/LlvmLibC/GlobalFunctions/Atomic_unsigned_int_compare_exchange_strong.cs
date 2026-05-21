using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Enumerations;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Atomic_unsigned_int_compare_exchange_strong
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp6AtomicIjE23compare_exchange_strongERjjNS0_11MemoryOrderENS0_11MemoryScopeE")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::Atomic<unsigned int>::compare_exchange_strong(unsigned int&, unsigned int, __llvm_libc_20_1_2_::cpp::MemoryOrder, __llvm_libc_20_1_2_::cpp::MemoryScope)")]
	public unsafe static bool Invoke(void* @this, [NativeType("unsigned int&")] void* expected, [NativeType("unsigned int")] int desired, [NativeType("__llvm_libc_20_1_2_::cpp::MemoryOrder")] MemoryOrder mem_ord, [NativeType("__llvm_libc_20_1_2_::cpp::MemoryScope")] MemoryScope mem_scope)
	{
		int num = desired;
		unchecked
		{
			Atomic_unsigned_int_addressof.Invoke(&((fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt*)@this)->field_0);
			int num2 = Atomic_unsigned_int_order.Invoke(mem_ord);
			void* ptr = Atomic_unsigned_int_addressof.Invoke(expected);
			void* ptr2 = Atomic_unsigned_int_addressof.Invoke(&num);
			int num3 = Atomic_unsigned_int_order.Invoke(mem_ord);
			sbyte b;
			switch (num2)
			{
			default:
			{
				int num6 = num3;
				if (num6 != 1 && num6 != 2)
				{
					if (num6 != 5)
					{
						_ = *(int*)ptr;
						_ = *(int*)ptr2;
						Struct_ycs3bi struct_ycs3bi19 = default(Struct_ycs3bi);
						Struct_ycs3bi struct_ycs3bi20 = struct_ycs3bi19;
						int field_13 = struct_ycs3bi20.field_0;
						Struct_ycs3bi struct_ycs3bi21 = struct_ycs3bi19;
						bool field_14 = struct_ycs3bi21.field_1;
						if (!field_14)
						{
							*(int*)ptr = field_13;
						}
						b = (field_14 ? ((sbyte)1) : ((sbyte)0));
					}
					else
					{
						_ = *(int*)ptr;
						_ = *(int*)ptr2;
						Struct_ycs3bi struct_ycs3bi22 = default(Struct_ycs3bi);
						Struct_ycs3bi struct_ycs3bi23 = struct_ycs3bi22;
						int field_15 = struct_ycs3bi23.field_0;
						Struct_ycs3bi struct_ycs3bi24 = struct_ycs3bi22;
						bool field_16 = struct_ycs3bi24.field_1;
						if (!field_16)
						{
							*(int*)ptr = field_15;
						}
						b = (field_16 ? ((sbyte)1) : ((sbyte)0));
					}
				}
				else
				{
					_ = *(int*)ptr;
					_ = *(int*)ptr2;
					Struct_ycs3bi struct_ycs3bi25 = default(Struct_ycs3bi);
					Struct_ycs3bi struct_ycs3bi26 = struct_ycs3bi25;
					int field_17 = struct_ycs3bi26.field_0;
					Struct_ycs3bi struct_ycs3bi27 = struct_ycs3bi25;
					bool field_18 = struct_ycs3bi27.field_1;
					if (!field_18)
					{
						*(int*)ptr = field_17;
					}
					b = (field_18 ? ((sbyte)1) : ((sbyte)0));
				}
				break;
			}
			case 1:
			case 2:
			{
				int num8 = num3;
				if (num8 != 1 && num8 != 2)
				{
					if (num8 != 5)
					{
						_ = *(int*)ptr;
						_ = *(int*)ptr2;
						Struct_ycs3bi struct_ycs3bi37 = default(Struct_ycs3bi);
						Struct_ycs3bi struct_ycs3bi38 = struct_ycs3bi37;
						int field_25 = struct_ycs3bi38.field_0;
						Struct_ycs3bi struct_ycs3bi39 = struct_ycs3bi37;
						bool field_26 = struct_ycs3bi39.field_1;
						if (!field_26)
						{
							*(int*)ptr = field_25;
						}
						b = (field_26 ? ((sbyte)1) : ((sbyte)0));
					}
					else
					{
						_ = *(int*)ptr;
						_ = *(int*)ptr2;
						Struct_ycs3bi struct_ycs3bi40 = default(Struct_ycs3bi);
						Struct_ycs3bi struct_ycs3bi41 = struct_ycs3bi40;
						int field_27 = struct_ycs3bi41.field_0;
						Struct_ycs3bi struct_ycs3bi42 = struct_ycs3bi40;
						bool field_28 = struct_ycs3bi42.field_1;
						if (!field_28)
						{
							*(int*)ptr = field_27;
						}
						b = (field_28 ? ((sbyte)1) : ((sbyte)0));
					}
				}
				else
				{
					_ = *(int*)ptr;
					_ = *(int*)ptr2;
					Struct_ycs3bi struct_ycs3bi43 = default(Struct_ycs3bi);
					Struct_ycs3bi struct_ycs3bi44 = struct_ycs3bi43;
					int field_29 = struct_ycs3bi44.field_0;
					Struct_ycs3bi struct_ycs3bi45 = struct_ycs3bi43;
					bool field_30 = struct_ycs3bi45.field_1;
					if (!field_30)
					{
						*(int*)ptr = field_29;
					}
					b = (field_30 ? ((sbyte)1) : ((sbyte)0));
				}
				break;
			}
			case 3:
			{
				int num5 = num3;
				if (num5 != 1 && num5 != 2)
				{
					if (num5 != 5)
					{
						_ = *(int*)ptr;
						_ = *(int*)ptr2;
						Struct_ycs3bi struct_ycs3bi10 = default(Struct_ycs3bi);
						Struct_ycs3bi struct_ycs3bi11 = struct_ycs3bi10;
						int field_7 = struct_ycs3bi11.field_0;
						Struct_ycs3bi struct_ycs3bi12 = struct_ycs3bi10;
						bool field_8 = struct_ycs3bi12.field_1;
						if (!field_8)
						{
							*(int*)ptr = field_7;
						}
						b = (field_8 ? ((sbyte)1) : ((sbyte)0));
					}
					else
					{
						_ = *(int*)ptr;
						_ = *(int*)ptr2;
						Struct_ycs3bi struct_ycs3bi13 = default(Struct_ycs3bi);
						Struct_ycs3bi struct_ycs3bi14 = struct_ycs3bi13;
						int field_9 = struct_ycs3bi14.field_0;
						Struct_ycs3bi struct_ycs3bi15 = struct_ycs3bi13;
						bool field_10 = struct_ycs3bi15.field_1;
						if (!field_10)
						{
							*(int*)ptr = field_9;
						}
						b = (field_10 ? ((sbyte)1) : ((sbyte)0));
					}
				}
				else
				{
					_ = *(int*)ptr;
					_ = *(int*)ptr2;
					Struct_ycs3bi struct_ycs3bi16 = default(Struct_ycs3bi);
					Struct_ycs3bi struct_ycs3bi17 = struct_ycs3bi16;
					int field_11 = struct_ycs3bi17.field_0;
					Struct_ycs3bi struct_ycs3bi18 = struct_ycs3bi16;
					bool field_12 = struct_ycs3bi18.field_1;
					if (!field_12)
					{
						*(int*)ptr = field_11;
					}
					b = (field_12 ? ((sbyte)1) : ((sbyte)0));
				}
				break;
			}
			case 4:
			{
				int num7 = num3;
				if (num7 != 1 && num7 != 2)
				{
					if (num7 != 5)
					{
						_ = *(int*)ptr;
						_ = *(int*)ptr2;
						Struct_ycs3bi struct_ycs3bi28 = default(Struct_ycs3bi);
						Struct_ycs3bi struct_ycs3bi29 = struct_ycs3bi28;
						int field_19 = struct_ycs3bi29.field_0;
						Struct_ycs3bi struct_ycs3bi30 = struct_ycs3bi28;
						bool field_20 = struct_ycs3bi30.field_1;
						if (!field_20)
						{
							*(int*)ptr = field_19;
						}
						b = (field_20 ? ((sbyte)1) : ((sbyte)0));
					}
					else
					{
						_ = *(int*)ptr;
						_ = *(int*)ptr2;
						Struct_ycs3bi struct_ycs3bi31 = default(Struct_ycs3bi);
						Struct_ycs3bi struct_ycs3bi32 = struct_ycs3bi31;
						int field_21 = struct_ycs3bi32.field_0;
						Struct_ycs3bi struct_ycs3bi33 = struct_ycs3bi31;
						bool field_22 = struct_ycs3bi33.field_1;
						if (!field_22)
						{
							*(int*)ptr = field_21;
						}
						b = (field_22 ? ((sbyte)1) : ((sbyte)0));
					}
				}
				else
				{
					_ = *(int*)ptr;
					_ = *(int*)ptr2;
					Struct_ycs3bi struct_ycs3bi34 = default(Struct_ycs3bi);
					Struct_ycs3bi struct_ycs3bi35 = struct_ycs3bi34;
					int field_23 = struct_ycs3bi35.field_0;
					Struct_ycs3bi struct_ycs3bi36 = struct_ycs3bi34;
					bool field_24 = struct_ycs3bi36.field_1;
					if (!field_24)
					{
						*(int*)ptr = field_23;
					}
					b = (field_24 ? ((sbyte)1) : ((sbyte)0));
				}
				break;
			}
			case 5:
			{
				int num4 = num3;
				if (num4 != 1 && num4 != 2)
				{
					if (num4 != 5)
					{
						_ = *(int*)ptr;
						_ = *(int*)ptr2;
						Struct_ycs3bi struct_ycs3bi = default(Struct_ycs3bi);
						Struct_ycs3bi struct_ycs3bi2 = struct_ycs3bi;
						int field_ = struct_ycs3bi2.field_0;
						Struct_ycs3bi struct_ycs3bi3 = struct_ycs3bi;
						bool field_2 = struct_ycs3bi3.field_1;
						if (!field_2)
						{
							*(int*)ptr = field_;
						}
						b = (field_2 ? ((sbyte)1) : ((sbyte)0));
					}
					else
					{
						_ = *(int*)ptr;
						_ = *(int*)ptr2;
						Struct_ycs3bi struct_ycs3bi4 = default(Struct_ycs3bi);
						Struct_ycs3bi struct_ycs3bi5 = struct_ycs3bi4;
						int field_3 = struct_ycs3bi5.field_0;
						Struct_ycs3bi struct_ycs3bi6 = struct_ycs3bi4;
						bool field_4 = struct_ycs3bi6.field_1;
						if (!field_4)
						{
							*(int*)ptr = field_3;
						}
						b = (field_4 ? ((sbyte)1) : ((sbyte)0));
					}
				}
				else
				{
					_ = *(int*)ptr;
					_ = *(int*)ptr2;
					Struct_ycs3bi struct_ycs3bi7 = default(Struct_ycs3bi);
					Struct_ycs3bi struct_ycs3bi8 = struct_ycs3bi7;
					int field_5 = struct_ycs3bi8.field_0;
					Struct_ycs3bi struct_ycs3bi9 = struct_ycs3bi7;
					bool field_6 = struct_ycs3bi9.field_1;
					if (!field_6)
					{
						*(int*)ptr = field_5;
					}
					b = (field_6 ? ((sbyte)1) : ((sbyte)0));
				}
				break;
			}
			}
			return (b & 1) == 1;
		}
	}
}
