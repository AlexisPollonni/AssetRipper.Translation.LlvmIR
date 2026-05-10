using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp6AtomicImE23compare_exchange_strongERmmNS0_11MemoryOrderES4_NS0_11MemoryScopeE")]
[DemangledName("__llvm_libc_20_1_2_::cpp::Atomic<unsigned long>::compare_exchange_strong(unsigned long&, unsigned long, __llvm_libc_20_1_2_::cpp::MemoryOrder, __llvm_libc_20_1_2_::cpp::MemoryOrder, __llvm_libc_20_1_2_::cpp::MemoryScope)")]
internal static partial class cpp_Atomic_unsigned_long_compare_exchange_strong_unsigned_long_unsigned_long_cpp_MemoryOrder_cpp_MemoryOrder_cpp_MemoryScope
{
	public unsafe static bool Invoke(void* @this, void* expected, long desired, int success_order, int failure_order, int mem_scope)
	{
		long num = desired;
		unchecked
		{
			cpp_Atomic_unsigned_long_addressof_unsigned_long.Invoke(&((fputil_internal_FPStorage_v3nexn*)@this)->val);
			int num2 = cpp_Atomic_unsigned_long_order_cpp_MemoryOrder.Invoke(success_order);
			void* ptr = cpp_Atomic_unsigned_long_addressof_unsigned_long.Invoke(expected);
			void* ptr2 = cpp_Atomic_unsigned_long_addressof_unsigned_long.Invoke(&num);
			int num3 = cpp_Atomic_unsigned_long_order_cpp_MemoryOrder.Invoke(failure_order);
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
						_ = *(long*)ptr;
						_ = *(long*)ptr2;
						Struct_u6p3uf struct_u6p3uf19 = default(Struct_u6p3uf);
						Struct_u6p3uf struct_u6p3uf20 = struct_u6p3uf19;
						long field_13 = struct_u6p3uf20.field_0;
						Struct_u6p3uf struct_u6p3uf21 = struct_u6p3uf19;
						bool field_14 = struct_u6p3uf21.field_1;
						if (!field_14)
						{
							*(long*)ptr = field_13;
						}
						b = (field_14 ? ((sbyte)1) : ((sbyte)0));
					}
					else
					{
						_ = *(long*)ptr;
						_ = *(long*)ptr2;
						Struct_u6p3uf struct_u6p3uf22 = default(Struct_u6p3uf);
						Struct_u6p3uf struct_u6p3uf23 = struct_u6p3uf22;
						long field_15 = struct_u6p3uf23.field_0;
						Struct_u6p3uf struct_u6p3uf24 = struct_u6p3uf22;
						bool field_16 = struct_u6p3uf24.field_1;
						if (!field_16)
						{
							*(long*)ptr = field_15;
						}
						b = (field_16 ? ((sbyte)1) : ((sbyte)0));
					}
				}
				else
				{
					_ = *(long*)ptr;
					_ = *(long*)ptr2;
					Struct_u6p3uf struct_u6p3uf25 = default(Struct_u6p3uf);
					Struct_u6p3uf struct_u6p3uf26 = struct_u6p3uf25;
					long field_17 = struct_u6p3uf26.field_0;
					Struct_u6p3uf struct_u6p3uf27 = struct_u6p3uf25;
					bool field_18 = struct_u6p3uf27.field_1;
					if (!field_18)
					{
						*(long*)ptr = field_17;
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
						_ = *(long*)ptr;
						_ = *(long*)ptr2;
						Struct_u6p3uf struct_u6p3uf37 = default(Struct_u6p3uf);
						Struct_u6p3uf struct_u6p3uf38 = struct_u6p3uf37;
						long field_25 = struct_u6p3uf38.field_0;
						Struct_u6p3uf struct_u6p3uf39 = struct_u6p3uf37;
						bool field_26 = struct_u6p3uf39.field_1;
						if (!field_26)
						{
							*(long*)ptr = field_25;
						}
						b = (field_26 ? ((sbyte)1) : ((sbyte)0));
					}
					else
					{
						_ = *(long*)ptr;
						_ = *(long*)ptr2;
						Struct_u6p3uf struct_u6p3uf40 = default(Struct_u6p3uf);
						Struct_u6p3uf struct_u6p3uf41 = struct_u6p3uf40;
						long field_27 = struct_u6p3uf41.field_0;
						Struct_u6p3uf struct_u6p3uf42 = struct_u6p3uf40;
						bool field_28 = struct_u6p3uf42.field_1;
						if (!field_28)
						{
							*(long*)ptr = field_27;
						}
						b = (field_28 ? ((sbyte)1) : ((sbyte)0));
					}
				}
				else
				{
					_ = *(long*)ptr;
					_ = *(long*)ptr2;
					Struct_u6p3uf struct_u6p3uf43 = default(Struct_u6p3uf);
					Struct_u6p3uf struct_u6p3uf44 = struct_u6p3uf43;
					long field_29 = struct_u6p3uf44.field_0;
					Struct_u6p3uf struct_u6p3uf45 = struct_u6p3uf43;
					bool field_30 = struct_u6p3uf45.field_1;
					if (!field_30)
					{
						*(long*)ptr = field_29;
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
						_ = *(long*)ptr;
						_ = *(long*)ptr2;
						Struct_u6p3uf struct_u6p3uf10 = default(Struct_u6p3uf);
						Struct_u6p3uf struct_u6p3uf11 = struct_u6p3uf10;
						long field_7 = struct_u6p3uf11.field_0;
						Struct_u6p3uf struct_u6p3uf12 = struct_u6p3uf10;
						bool field_8 = struct_u6p3uf12.field_1;
						if (!field_8)
						{
							*(long*)ptr = field_7;
						}
						b = (field_8 ? ((sbyte)1) : ((sbyte)0));
					}
					else
					{
						_ = *(long*)ptr;
						_ = *(long*)ptr2;
						Struct_u6p3uf struct_u6p3uf13 = default(Struct_u6p3uf);
						Struct_u6p3uf struct_u6p3uf14 = struct_u6p3uf13;
						long field_9 = struct_u6p3uf14.field_0;
						Struct_u6p3uf struct_u6p3uf15 = struct_u6p3uf13;
						bool field_10 = struct_u6p3uf15.field_1;
						if (!field_10)
						{
							*(long*)ptr = field_9;
						}
						b = (field_10 ? ((sbyte)1) : ((sbyte)0));
					}
				}
				else
				{
					_ = *(long*)ptr;
					_ = *(long*)ptr2;
					Struct_u6p3uf struct_u6p3uf16 = default(Struct_u6p3uf);
					Struct_u6p3uf struct_u6p3uf17 = struct_u6p3uf16;
					long field_11 = struct_u6p3uf17.field_0;
					Struct_u6p3uf struct_u6p3uf18 = struct_u6p3uf16;
					bool field_12 = struct_u6p3uf18.field_1;
					if (!field_12)
					{
						*(long*)ptr = field_11;
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
						_ = *(long*)ptr;
						_ = *(long*)ptr2;
						Struct_u6p3uf struct_u6p3uf28 = default(Struct_u6p3uf);
						Struct_u6p3uf struct_u6p3uf29 = struct_u6p3uf28;
						long field_19 = struct_u6p3uf29.field_0;
						Struct_u6p3uf struct_u6p3uf30 = struct_u6p3uf28;
						bool field_20 = struct_u6p3uf30.field_1;
						if (!field_20)
						{
							*(long*)ptr = field_19;
						}
						b = (field_20 ? ((sbyte)1) : ((sbyte)0));
					}
					else
					{
						_ = *(long*)ptr;
						_ = *(long*)ptr2;
						Struct_u6p3uf struct_u6p3uf31 = default(Struct_u6p3uf);
						Struct_u6p3uf struct_u6p3uf32 = struct_u6p3uf31;
						long field_21 = struct_u6p3uf32.field_0;
						Struct_u6p3uf struct_u6p3uf33 = struct_u6p3uf31;
						bool field_22 = struct_u6p3uf33.field_1;
						if (!field_22)
						{
							*(long*)ptr = field_21;
						}
						b = (field_22 ? ((sbyte)1) : ((sbyte)0));
					}
				}
				else
				{
					_ = *(long*)ptr;
					_ = *(long*)ptr2;
					Struct_u6p3uf struct_u6p3uf34 = default(Struct_u6p3uf);
					Struct_u6p3uf struct_u6p3uf35 = struct_u6p3uf34;
					long field_23 = struct_u6p3uf35.field_0;
					Struct_u6p3uf struct_u6p3uf36 = struct_u6p3uf34;
					bool field_24 = struct_u6p3uf36.field_1;
					if (!field_24)
					{
						*(long*)ptr = field_23;
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
						_ = *(long*)ptr;
						_ = *(long*)ptr2;
						Struct_u6p3uf struct_u6p3uf = default(Struct_u6p3uf);
						Struct_u6p3uf struct_u6p3uf2 = struct_u6p3uf;
						long field_ = struct_u6p3uf2.field_0;
						Struct_u6p3uf struct_u6p3uf3 = struct_u6p3uf;
						bool field_2 = struct_u6p3uf3.field_1;
						if (!field_2)
						{
							*(long*)ptr = field_;
						}
						b = (field_2 ? ((sbyte)1) : ((sbyte)0));
					}
					else
					{
						_ = *(long*)ptr;
						_ = *(long*)ptr2;
						Struct_u6p3uf struct_u6p3uf4 = default(Struct_u6p3uf);
						Struct_u6p3uf struct_u6p3uf5 = struct_u6p3uf4;
						long field_3 = struct_u6p3uf5.field_0;
						Struct_u6p3uf struct_u6p3uf6 = struct_u6p3uf4;
						bool field_4 = struct_u6p3uf6.field_1;
						if (!field_4)
						{
							*(long*)ptr = field_3;
						}
						b = (field_4 ? ((sbyte)1) : ((sbyte)0));
					}
				}
				else
				{
					_ = *(long*)ptr;
					_ = *(long*)ptr2;
					Struct_u6p3uf struct_u6p3uf7 = default(Struct_u6p3uf);
					Struct_u6p3uf struct_u6p3uf8 = struct_u6p3uf7;
					long field_5 = struct_u6p3uf8.field_0;
					Struct_u6p3uf struct_u6p3uf9 = struct_u6p3uf7;
					bool field_6 = struct_u6p3uf9.field_1;
					if (!field_6)
					{
						*(long*)ptr = field_5;
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
